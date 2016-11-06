using UnityEngine;
using System.Collections;

public class BeamShooter : MonoBehaviour {
    int count = 0;

	// Use this for initialization
	void Start () {
	
	}

    //drag prefab here in editor
    // public BasicBeamShot InstantiateMe;

    public GameObject BasicBeamShot;
    public GameObject m_shotPrefab;
    public Transform m_muzzle;
    // Update is called once per frame
    void Update() {
        count++;
        if (count < 20) return;
        count = 0;
        //you don't have to instantiate at the transform's positio nand rotation, swap these for what suits your needs
        // GameObject superMuzzle = (GameObject)Instantiate(BasicBeamShot, transform.position, transform.rotation);
        // superMuzzle.GetComponent<BeamParam>().SetBeamParam(this.GetComponent<BeamParam>());
        Vector3 rot = -m_muzzle.rotation.eulerAngles;
        //rot.z += 90;
        GameObject go = GameObject.Instantiate(m_shotPrefab, m_muzzle.position, Quaternion.Euler(rot)) as GameObject;
        Vector3 scale = new Vector3(.002f,.002f,.002f);
        go.transform.localScale=scale;
        GameObject.Destroy(go, 15f);
    }
}
