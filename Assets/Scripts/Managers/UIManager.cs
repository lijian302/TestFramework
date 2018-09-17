using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : ManagerBase
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UIManager();
            }
            return instance;
        }
    }

    private UIManager() { }

    public override void SendMessage(MessageBase message)
    {
        if (message.GetManager() == ManagerId.UIManager)
        {
            ProcessEvent(message);
        }
        else
        {
            MessageCenter.Instance.SendMessage(message);
        }
    }
}
