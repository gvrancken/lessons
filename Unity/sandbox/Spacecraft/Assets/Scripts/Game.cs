using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    List<Projectile> projectiles;
    SpaceCraft[] spaceCrafts;
    List<SpaceCraft> cooledDownSpaceCrafts;
    // List<Vector3> projectilePositions;

    // Use this for initialization
    void Start () {
        projectiles = new List<Projectile>();
        cooledDownSpaceCrafts = new List<SpaceCraft>();
        spaceCrafts = FindObjectsOfType<SpaceCraft>();

        Debug.Log("I needed to instantiate!");
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = Camera.main.transform.position;
        Vector3 mousePos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0)) 
        // clicked left mouse
        {
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity)) 
            // we hit something
            {
                if (hitInfo.rigidbody)
                {
                    if (hitInfo.rigidbody.gameObject.GetComponent<SpaceCraft>())
                    {
                        // it's the spacecraft
                        SpaceCraft sc = hitInfo.rigidbody.gameObject.GetComponent<SpaceCraft>();
                        if (!cooledDownSpaceCrafts.Contains(sc))
                        {
                            GameObject Proj = Instantiate(sc.projectilePrefab, sc.shootPoint.transform.position, Quaternion.identity);
                            // shoot
                            // projectilePositions.Add(sc.shootPoint.transform.position);
                            cooledDownSpaceCrafts.Add(sc);
                            projectiles.Add(Proj.GetComponent<Projectile>());
                        }
                    }
                }
            }
        }

        for (int i = projectiles.Count-1; i >= 0; --i)
        {
            Projectile p = projectiles[i];
            
            p.timeAlive += Time.deltaTime;

            float acc = 1.1f;
            p.speed *= acc;
            p.pos = p.pos + (Vector3.forward * p.speed * Time.deltaTime);

            p.transform.position = p.pos + (Vector3.up * p.bobbing.Evaluate(p.timeAlive));

            if (p.timeAlive > 2f)
            {
                projectiles.Remove(p);
                Destroy(p.gameObject);
                p = null;
            }
        }

        // do some awesome bobbing
        for (int i = spaceCrafts.Length - 1; i >= 0; --i)
        {
            SpaceCraft sc = spaceCrafts[i];
            sc.transform.position = sc.pos + (Vector3.up * sc.bobbing.Evaluate(Time.time) * 0.5f);
        }

        for (int i = cooledDownSpaceCrafts.Count - 1; i >= 0; --i)
        {
            SpaceCraft sc = cooledDownSpaceCrafts[i];
            sc.coolDownTimer += Time.deltaTime;
            sc.rot = Quaternion.Euler(0, 0, 360 * (sc.coolDownTimer / sc.shotCoolDown));
            sc.transform.rotation = sc.rot;
            if (sc.coolDownTimer >= sc.shotCoolDown)
            {
                cooledDownSpaceCrafts.Remove(sc);
                sc.coolDownTimer = 0;
            }
        }

    }
}
