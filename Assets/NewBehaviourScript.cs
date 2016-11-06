using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = this.transform.position;
        Vector3 scale = transform.localScale;
        scale.x = .02F; // your new value
        scale.y = .02F; // your new value
        scale.z = .02F; // your new value
        sphere.transform.localScale = scale;
    }
}
