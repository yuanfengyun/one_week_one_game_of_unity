using UnityEngine;
using System;
using System.Collections.Generic;

public class Notification
{
    /// <summary>
    /// 发送者
    /// </summary>
    public GameObject sender;

    /// <summary>
    /// 消息内容
    /// </summary>
    public EventArgs param;

    /// <summary>
    /// 构造函数 （初始化）
    /// </summary>
    ///<param name="sender">通知发送者
    ///<param name="param">通知内容
    public Notification(GameObject sender, EventArgs param)
    {
        this.sender = sender;
        this.param = param;
    }

    public Notification()
    {

    }

    /// <summary>
    /// 构造函数
    /// </summary>
    ///<param name="param">
    public Notification(EventArgs param)
    {
        this.sender = null;
        this.param = param;
    }
}
/// <summary>
/// 传递的消息，这个是消息类中的具体消息种类 类
/// </summary>
public class EventArgsTest : EventArgs
{
    public int id;
    public string name;
}

/// <summary>
/// 消息类型，枚举列出，调用时需要强转为uint
/// </summary>
public enum ENotificationMsgType // 消息发送的枚举值，应该转为uint型
{
    ENull = 0, //Test
    EGameOver = 1,
}

public delegate void NotificationDelegate(Notification notific);

public class NotificationCenter
{
    private static NotificationCenter instance = null;
    public static NotificationCenter Get()
    {
        if (instance == null)
        {
            instance = new NotificationCenter();
            return instance;
        }
        return instance;
    }

    private Dictionary<uint, NotificationDelegate> eventListeners
        = new Dictionary<uint, NotificationDelegate>();
    public void AddEventListener(uint eventKey, NotificationDelegate listener)
    {
        if (!HasEventListener(eventKey))
        {
            NotificationDelegate del = null; //定义方法
            eventListeners[eventKey] = del;// 给委托变量赋值
        }
        eventListeners[eventKey] += listener; //注册接收者的监听
    }
    public void RemoveEventListener(uint eventKey, NotificationDelegate listener)
    {
        if (!HasEventListener(eventKey))
            return;
        eventListeners[eventKey] -= listener;
        if (eventListeners[eventKey] == null)
        {
            RemoveEventListener(eventKey);
        }
    }
    public void RemoveEventListener(uint eventKey)
    {
        eventListeners.Remove(eventKey);
    }

    /// <summary>
    /// 分发事件，不需要知道发送者的情况
    /// </summary>
    /// <param name="eventKey"></param>
    /// <param name="notific"></param>
    public void PostDispatchEvent(uint eventKey, Notification notific)
    {
        if (!HasEventListener(eventKey))
            return;
        // eventListeners[eventKey].Invoke(notific);
        eventListeners[eventKey](notific);
    }

    /// <summary>
    /// 分发事件，需要知道发送者，具体消息的情况
    /// </summary>
    ///<param name="eventKey">事件Key
    ///<param name="sender">发送者
    ///<param name="param">通知内容
    public void PostDispatchEvent(uint eventKey, GameObject sender, EventArgs param)
    {
        if (!HasEventListener(eventKey))
            return;
        eventListeners[eventKey](new Notification(sender, param));
    }

    public void PostDispatchEvent(uint eventKey)
    {
        if (!HasEventListener(eventKey))
            return;
        eventListeners[eventKey](new Notification());
    }

    /// <summary>
    /// 分发事件，不需要知道任何，只需要知道发送过来消息了
    /// </summary>
    ///<param name="eventKey">事件Key
    ///<param name="param">通知内容
    public void PostDispatchEvent(uint eventKey, EventArgs param)
    {
        if (!HasEventListener(eventKey))
            return;
        eventListeners[eventKey](new Notification(param));
    }

    /// <summary>
    /// 是否存在指定事件的监听器
    /// </summary>
    public bool HasEventListener(uint eventKey)
    {
        return eventListeners.ContainsKey(eventKey);
    }
}