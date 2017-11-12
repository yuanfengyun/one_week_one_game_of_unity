using UnityEngine;
using System.Collections;

public class ColliderEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log ("-------开始碰撞------------");
        Debug.Log(coll.gameObject.name);
        NotificationCenter.Get().PostDispatchEvent((uint)ENotificationMsgType.EGameOver);
    }

    void OnCollisionStay2D(Collision2D coll) {
      Debug.Log ("------正在碰撞-------------");
      Debug.Log(coll.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D coll) {
      Debug.Log ("------结束碰撞-------------");
      Debug.Log(coll.gameObject.name);
    }
}
