using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI2 : MonoBehaviour, IMessageProcess
{
    private void Start()
    {
        ushort[] messageIds = new ushort[]
        {
            (ushort)UIMessageId.Message1,
            (ushort)UIMessageId.Message2
        };
        UIManager.Instance.RegistMessage(messageIds, this);
    }

    public void ProcessEvent(MessageBase message)
    {
        if (message.MessageId == (ushort)UIMessageId.Message1)
        {
            Debug.Log("UIGetUIMessage1");
        }
        else if (message.MessageId == (ushort)UIMessageId.Message2)
        {
            Vector3 pos = (message as UIPositionMessage).UIPostion;
            Debug.Log("UIGetUIMessage2: " + pos);
        }
    }
}
