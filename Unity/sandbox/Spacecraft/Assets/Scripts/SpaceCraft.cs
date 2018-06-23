using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCraft : MonoBehaviour {

    public Vector3 pos;
    public Quaternion rot;
    public GameObject shootPoint;
    public GameObject projectilePrefab;
    public float shotCoolDown = 1;
    public float coolDownTimer = 0;
    public AnimationCurve bobbing;

    void Awake()
    {
        pos = transform.position;
    }
}
