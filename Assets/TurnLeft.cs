using UnityEngine;
using System.Collections;

public class TurnLeft : MonoBehaviour {
    float movementSpeed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 forward = Utils.rotateVector(transform.forward,90);
        transform.position += forward * Time.deltaTime * movementSpeed;
    }
}
