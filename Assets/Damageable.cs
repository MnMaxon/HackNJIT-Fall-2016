using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {
    public int health;
    public AudioClip harmNoise;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll) {
        if(coll.collider.GetComponent<MoveAlongPath>()==null) return;
        health--;
        if (harmNoise != null) AudioSource.PlayClipAtPoint(harmNoise, Camera.main.transform.position);
        GameObject.Destroy(coll.gameObject);
        if(health <= 0) GameObject.Destroy(gameObject);
    }
}
