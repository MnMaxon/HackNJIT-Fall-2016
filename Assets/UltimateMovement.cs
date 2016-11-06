using UnityEngine;
using System.Collections;

public class UltimateMovement : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Transform target = Camera.main.transform;
        if (transform.position.y > 2.5) return;
        if (Vector3.Distance(transform.position, target.position) < 10) return;
        transform.LookAt(target.position);
        
        transform.Rotate(new Vector3(0, 0, 0), Space.Self);
        //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }
}
