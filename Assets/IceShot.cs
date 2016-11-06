using UnityEngine;
using System.Collections;

public class IceShot : MonoBehaviour {
    int lastFrame=0;
    Vector3[] vecs = new Vector3[5];
    float veryLarge;
    int count = 0;
    public GameObject iceShot;
    public float size=.2f;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        Vector3 vec = transform.position;
        vecs[lastFrame] = vec;
        float total = 0;
        int div = 0;
        for (int i = 0; i < vecs.Length-1; i++) {
            if (vecs[i+1] == null){
                vecs[0] = vec;
                vecs[i + 1] = vecs[i];
                return;
            }
            total += Utils.getDistance(vecs[i],vecs[i+1]);
            vecs[i + 1] = vecs[i];
            div++;
        }
        vecs[0] = vec;
        count++;
        if (count < 40) return;
        float avg = total / div;
        if (avg > .015&&avg<.03)
        {
            if (veryLarge < 1)            veryLarge = avg;
            count = 0;
            //Quaternion.FromToRotation(vecs[1], vecs[0]);
            GameObject go = GameObject.Instantiate(iceShot) as GameObject;
            go.transform.position = transform.position;
            go.transform.localScale = new Vector3(size, size, size);
            go.GetComponent<MoveAlongPath>().direc = Utils.getDirection(Camera.main.transform.position, vec);
        }
    }
}
