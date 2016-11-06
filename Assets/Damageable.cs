using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {
    public int health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll) {
        if(coll.collider.GetComponent<MoveAlongPath>()==null) return;
        health--;
        GameObject.Destroy(coll.gameObject);
        if(health <= 0)GameObject.Destroy(gameObject);
    }
}
