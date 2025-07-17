using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventController : MonoBehaviour
{
    /// <summary>
    /// 委托事件
    /// </summary>
    public delegate void EventHandler(object data);
    
    /// <summary>
    /// 事件派发注册字典
    /// </summary>
    private static Dictionary<UIEventEnum, List<EventHandler>> mEventDic = new Dictionary<UIEventEnum, List<EventHandler>>();

    public static void AddEvent(UIEventEnum eventType, EventHandler handler)
    {
        if (!mEventDic.ContainsKey(eventType))
        {
            mEventDic.Add(eventType, new List<EventHandler>());
        }

        if (!mEventDic[eventType].Contains(handler))
        {
            mEventDic[eventType].Add(handler);
        }
    }

    public static void RemoveEvent(UIEventEnum eventType, EventHandler handler)
    {
        if (!mEventDic.ContainsKey(eventType)) return;
        if (mEventDic[eventType].Contains(handler))
        {
            mEventDic[eventType].Remove(handler);
        }
    }
    
    /// <summary>
    /// 分发事件
    /// </summary>
    /// <param name="eventType"></param>
    /// <param name="data"></param>
    public static void DispatchEvent(UIEventEnum eventType, object data = null)
    {
        if (!mEventDic.TryGetValue(eventType, out var value)) return;
        foreach (var handler in value)
        {
            handler?.Invoke(data);
        }
    }
}
