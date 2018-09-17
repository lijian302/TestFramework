using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("SendUIMessage1");
            MessageBase message = new MessageBase((ushort)UIMessageId.Message1);
            UIManager.Instance.SendMessage(message);
            Debug.Log("SendPlayerMessage1");
            message = new MessageBase((ushort)PlayerMessageId.Message1);
            UIManager.Instance.SendMessage(message);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("SendUIMessage2");
            UIPositionMessage message = new UIPositionMessage((ushort)UIMessageId.Message2)
            {
                UIPostion = Vector3.one
            };
            UIManager.Instance.SendMessage(message);
        }
    }
}

public class UIPositionMessage : MessageBase
{
    public Vector3 UIPostion { get; set; }

    public UIPositionMessage(ushort messageId) : base(messageId)
    {
    }
}
