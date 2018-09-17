using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理器基类
/// </summary>
public abstract class ManagerBase : IMessageProcess
{
    public abstract ManagerId Id { get; }
    private NodeList<ushort, IMessageProcess> nodeList;

    public ManagerBase()
    {
        nodeList = new NodeList<ushort, IMessageProcess>();
        MessageCenter.Instance.AddManager(this);
    }

    /// <summary>
    /// 注册消息
    /// </summary>
    /// <param name="messages"></param>
    /// <param name="messageProcess"></param>
    public void RegistMessage(ushort[] messages, IMessageProcess messageProcess)
    {
        nodeList.AddNode(messages, messageProcess);
    }

    /// <summary>
    /// 取消注册消息
    /// </summary>
    /// <param name="messages"></param>
    /// <param name="messageProcess"></param>
    public void UnRegistMessage(ushort[] messages, IMessageProcess messageProcess)
    {
        nodeList.RemoveNode(messages, messageProcess);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="message"></param>
    public void SendMessage(MessageBase message)
    {
        MessageCenter.Instance.SendMessage(message);
    }

    /// <summary>
    /// 处理消息
    /// </summary>
    /// <param name="message"></param>
    public void ProcessEvent(MessageBase message)
    {
        if (!nodeList.ContainKey(message.MessageId))
        {
            Debug.LogError("Key not exist! MessageId: " + message.MessageId + ", ManagerId: " + message.GetManager());
        }
        else
        {
            Node<IMessageProcess> temp = nodeList[message.MessageId];
            while (temp != null)
            {
                temp.data.ProcessEvent(message);
                temp = temp.next;
            }
        }
    }
}
