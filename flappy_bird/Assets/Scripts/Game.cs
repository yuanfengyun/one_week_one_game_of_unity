using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    public GameObject logo;
    public GameObject btnOk;
    public GameObject gameover;

    void Awake()
    {
        NotificationCenter.Get().AddEventListener((uint)ENotificationMsgType.EGameOver, GameOver);
    }

    void OnDestroy()
    {
        NotificationCenter.Get().RemoveEventListener((uint)ENotificationMsgType.EGameOver, GameOver);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("点击");
            Vector3 screenpos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(screenpos);
            RaycastHit hitinfo;
            if (Physics.Raycast(ray, out hitinfo))
            {
                Debug.Log(hitinfo.transform.name);
                if (hitinfo.transform.name == "BtnOK")
                {
                    //GameControl.isGamePlaying = true;
                    //Application.LoadLevel("Start");
                }
                if (hitinfo.transform.name == "BtnRate")
                {
                    //Application.OpenURL("http://user.qzone.qq.com/375388697");
                }
            }
            if(Control.state == "welcome")
            {
                StartGame();
            }
        }
    }

    void StartGame()
    {
        btnOk.SetActive(false);
        logo.SetActive(false);
        Control.state = "play";
    }

    void GameOver(Notification n)
    {
        Control.state = "welcome";
        gameover.SetActive(true);
    }

}
