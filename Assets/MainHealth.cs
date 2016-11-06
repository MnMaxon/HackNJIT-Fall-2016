using UnityEngine;
using System.Collections;

public class MainHealth : MonoBehaviour {
    public int health;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Object[] objs = GameObject.FindObjectsOfType(typeof(ShotBehavior));
        for (int i=0;i<objs.Length;i++)
        {
            ShotBehavior laser = objs[i] as ShotBehavior;
            if(!gameObject.GetComponent<CapsuleCollider>().bounds.Contains(laser.transform.position)) continue;
            health--;
            GameObject.Destroy(laser.gameObject);
        }
    }
}
