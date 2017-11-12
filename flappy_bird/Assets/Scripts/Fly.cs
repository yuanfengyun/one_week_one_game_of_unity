using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {
    public float speed = 0.8f;
    public int up = 1;
    public float interval = 0;
    public float max = 2; 

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Control.state != "play")
        {
            return;
        }
        interval += Time.deltaTime;
        if (interval > max)
        {
            interval = 0;
            up = -up;
        }

        if (up > 0)
        {
            this.transform.Translate(-Vector3.up * speed * Time.deltaTime);
            
        }
        else
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
	}
}
