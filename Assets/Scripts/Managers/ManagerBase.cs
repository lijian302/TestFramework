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

    public void RegistMessage(ushort[] messages, IMessageProcess messageProcess)
    {
        nodeList.AddNode(messages, messageProcess);
    }

    public void UnRegistMessage(ushort[] messages, IMessageProcess messageProcess)
    {
        nodeList.RemoveNode(messages, messageProcess);
    }

    public void SendMessage(MessageBase message)
    {
        MessageCenter.Instance.SendMessage(message);
    }

    public void ProcessEvent(MessageBase message)
    {
        if (!nodeList.ContainKey(message.MessageId))
        {
            Debug.LogError("Key not exist!");
            Debug.LogError("messageId: " + message.MessageId + ", managerId: " + message.GetManager());
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
