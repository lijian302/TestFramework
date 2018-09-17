using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBase : MonoBase
{
    private NodeList<ushort, MonoBase> nodeList;

    public ManagerBase()
    {
        nodeList = new NodeList<ushort, MonoBase>();
    }

    public void RegistMessage(ushort[] messages, MonoBase mono)
    {
        nodeList.AddNode(messages, mono);
    }

    public void UnRegistMessage(ushort[] messages, MonoBase mono)
    {
        nodeList.RemoveNode(messages, mono);
    }

    public override void ProcessEvent(MessageBase message)
    {
        if (!nodeList.ContainKey(message.MessageId))
        {
            Debug.LogError("Key not exist!");
            Debug.LogError("messageId: " + message.MessageId + ", managerId: " + message.GetManager());
        }
        else
        {
            Node<MonoBase> temp = nodeList[message.MessageId];
            while (temp != null)
            {
                temp.data.ProcessEvent(message);
                temp = temp.next;
            }
        }
    }
}
