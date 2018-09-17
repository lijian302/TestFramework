using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 消息中心
/// </summary>
public class MessageCenter
{
    private static MessageCenter instance;
    public static MessageCenter Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MessageCenter();
            }
            return instance;
        }
    }

    private List<ManagerBase> managers;

    private MessageCenter()
    {
        managers = new List<ManagerBase>();
    }

    /// <summary>
    /// 添加管理器
    /// </summary>
    /// <param name="manager"></param>
    public void AddManager(ManagerBase manager)
    {
        if (!managers.Contains(manager))
            managers.Add(manager);
    }

    /// <summary>
    /// 移除管理器
    /// </summary>
    /// <param name="manager"></param>
    public void RemoveManager(ManagerBase manager)
    {
        if (managers.Contains(manager))
            managers.Remove(manager);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="message"></param>
    public void SendMessage(MessageBase message)
    {
        ManagerBase manager = managers.Find(m => m.Id == message.GetManager());
        if (manager != null)
        {
            manager.ProcessEvent(message);
        }
    }
}
