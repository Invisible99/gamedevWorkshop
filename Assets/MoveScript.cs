using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    public float speed;
    private Transform trans;
    // Use this for initialization
    void Start() {
        trans = GetComponent<Transform>() as Transform;
	}
	
	// Update is called once per frame
	void Update () {
        trans.position = trans.position + new Vector3(speed * Time.deltaTime, 0, 0);
	}
}
