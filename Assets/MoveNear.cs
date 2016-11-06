using UnityEngine;
using System.Collections;

public class MoveNear : MonoBehaviour {
    public bool end = false;
    public float speed = .4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Transform target = Camera.main.transform;
        if (end||transform.position.y>0) return;
        if (Vector3.Distance(transform.position, target.position) < 10) {
            end = true;
            return;
        }
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, 90, 0), Space.Self);
        //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }
}
