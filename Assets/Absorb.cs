using UnityEngine;
using System.Collections;

public class Absorb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Object[] objs = GameObject.FindObjectsOfType(typeof(ShotBehavior));
        for (int i = 0; i < objs.Length; i++)
        {
            ShotBehavior laser = objs[i] as ShotBehavior;
            if (Vector3.Distance(gameObject.transform.position,laser.transform.position)>.9f) continue;
            GameObject laserObj = laser.gameObject;
            GameObject.Destroy(laser);
            Rigidbody rig=laserObj.AddComponent<Rigidbody>();
            rig.useGravity = true;
        }
    }
}
