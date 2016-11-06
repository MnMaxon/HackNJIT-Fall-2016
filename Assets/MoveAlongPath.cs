using UnityEngine;
using System.Collections;

public class MoveAlongPath : MonoBehaviour {
    public Vector3 direc;
    public float speed = .2f;
	// Use this for initialization
	void Start ()
    {
        //transform.Translate(speed * direc.x, speed * direc.y, speed * direc.z);
        //gameObject.transform.LookAt(Camera.main.transform);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //GameObject closest = null;
        //Object[] objs = GameObject.FindObjectsOfType(typeof(Damageable));
        //for (int i =0;i<objs.Length;i++) {
        //    Damageable damagable = objs[i] as Damageable;
        //    float dist = Vector3.Distance(damagable.transform.position,transform.position);
        //    if (dist < 3 && (closest == null || dist < Vector3.Distance(closest.transform.position, transform.position)))
        //        closest = damagable.gameObject;
        //}
        //if (closest == null)
            transform.Translate(speed * direc.x, speed * direc.y, speed * direc.z);
        //else { transform.LookAt(closest.transform.position);
        //    transform.Translate(speed * transform.forward.x, speed * transform.forward.y, speed * transform.forward.z);
        //}
    }
}
