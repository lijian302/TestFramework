using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour, IMessageProcess
{
    private void Start()
    {
        ushort[] messageIds = new ushort[1] { (ushort)UIMessageId.Message1 };
        UIManager.Instance.RegistMessage(messageIds, this);
    }

    public void ProcessEvent(MessageBase message)
    {
        if (message.MessageId == (ushort)UIMessageId.Message1)
        {
            Debug.Log("PlayerGetUIMessage1");
        }
    }
}
