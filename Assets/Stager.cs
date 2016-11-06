using UnityEngine;
using System.Collections;

public class Stager : MonoBehaviour {
    private int stage=0;
    public GameObject boss1;
    public GameObject berd;
    public GameObject cubert;
    public GameObject edawg;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (stage == 0)
        {
            if (GameObject.FindObjectsOfType(typeof(Hand)).Length > 1)
            {
                stage++;
                float x = Camera.main.transform.forward.x, z = Camera.main.transform.forward.z;
                float max = Mathf.Max(x, z);
                Vector3 ray = new Vector3(x / max, 0, z / max);
                GameObject monster = GameObject.Instantiate(berd);
                monster.transform.position = Camera.main.transform.position + 2f * ray;
            }
        }
        else if (stage == 1)
        {
            if (GameObject.FindObjectsOfType(typeof(BerdHover)).Length == 0)
            {
                stage++;
                float val = 20, y = 10;
                GameObject c1 = GameObject.Instantiate(cubert);
                GameObject c2 = GameObject.Instantiate(cubert);
                GameObject c3 = GameObject.Instantiate(cubert);
                GameObject c4 = GameObject.Instantiate(cubert);
                c1.transform.position = new Vector3(val, y, -val);
                c2.transform.position = new Vector3(val, y, val); ;
                c3.transform.position = new Vector3(-val, y, val); ;
                c4.transform.position = new Vector3(-val, y, -val);
            }
        }
        else if (stage == 2)
        {
            if (GameObject.FindObjectsOfType(typeof(MoveNear)).Length == 0)
            {
                GameObject monster = GameObject.Instantiate(boss1);
                float x = Camera.main.transform.forward.x, z = Camera.main.transform.forward.z;
                float max = Mathf.Max(x, z);
                Vector3 ray = new Vector3(x / max, 1f, z / max);

                boss1.transform.position = Camera.main.transform.position + 10f * ray;
                stage++;
            }
        }
        else if (stage == 3)
        {
            if (GameObject.FindObjectsOfType(typeof(Damageable)).Length == 0) {
            stage++;
            float x = Camera.main.transform.forward.x, z = Camera.main.transform.forward.z;
            float max = Mathf.Max(x, z);
            Vector3 ray = new Vector3(x / max, 5, z / max);
            GameObject monster = GameObject.Instantiate(edawg);
            monster.transform.position = new Vector3(0, 0, 15f);
                monster.transform.Rotate(180, 180, 0);
        }
        } else
        {
            if (GameObject.FindObjectsOfType(typeof(Damageable)).Length == 0)
            {
                stage++;
                float val = 20, y = 10;
                SpawnCuberts(val, y);
                SpawnCuberts(val, y + 1);
            }
        }
    }

    public void SpawnCuberts(float val, float y) {
        GameObject c1 = GameObject.Instantiate(cubert);
        GameObject c2 = GameObject.Instantiate(cubert);
        GameObject c3 = GameObject.Instantiate(cubert);
        GameObject c4 = GameObject.Instantiate(cubert);
        c1.transform.position = new Vector3(val, y, -val);
        c2.transform.position = new Vector3(val, y, val); ;
        c3.transform.position = new Vector3(-val, y, val); ;
        c4.transform.position = new Vector3(-val, y, -val);
    }
}
