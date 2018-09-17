using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour, IMessageProcess
{
    private void Start()
    {
        ushort[] messageIds = new ushort[]
        {
            (ushort)PlayerMessageId.Message1
        };
        PlayerManager.Instance.RegistMessage(messageIds, this);
    }

    public void ProcessEvent(MessageBase message)
    {
        if (message.MessageId == (ushort)PlayerMessageId.Message1)
        {
            Debug.Log("GetPlayerMessage1");
        }
    }
}
