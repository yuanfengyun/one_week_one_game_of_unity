using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {
    private float min = -4;
    private float max = 4;
    public GameObject other;
    public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Control.state != "play")
        {
            return;
        }
        this.transform.Translate(Vector3.left* speed * Time.deltaTime);
        this.other.transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (this.transform.position.x < min)
        {
            Vector3 v = this.transform.position;
            v.x = max;
            this.transform.position = v;

            v = this.other.transform.position;
            v.x = max;
            this.other.transform.position = v;
        }
    }
}
