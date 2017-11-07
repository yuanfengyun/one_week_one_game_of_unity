using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
    public float speed = 1.0f;
    public float left = -0.46f;
    public float right = 0.74f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(this.transform.position.x < left)
        {
            Vector3 v = this.transform.position;
            v.x = 0.74f;
            this.transform.position = v;
        }
    }
}
