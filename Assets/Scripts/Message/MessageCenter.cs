using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private MessageCenter() { }

    public void SendMessage(MessageBase message)
    {
        ManagerId managerId = message.GetManager();
        switch (managerId)
        {
            case ManagerId.UIManager:
                break;
            case ManagerId.GameManager:
                break;
            case ManagerId.PlayerManager:
                break;
            default:
                break;
        }
    }
}
