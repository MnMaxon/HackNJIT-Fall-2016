using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = Utils.getDirection(transform.position, Camera.main.transform.position);
        direction.y -= .05f;
		transform.position += direction * Time.deltaTime * 10f;
	}
}
