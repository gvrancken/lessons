using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public Vector3 pos;
    public float timeAlive;
    public float timeToDie;
    public float speed;
    public AnimationCurve bobbing;

    public Projectile(Vector3 startPos)
    {
        timeAlive = 0;
        pos = startPos;
    }

}
