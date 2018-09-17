using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ManagerId
{
    UIManager = 0,
    GameManager = MessageBase.span,
    PlayerManager = MessageBase.span * 2
}

public class MessageBase
{
    public const int span = 3000;
    private ushort messageId;
    public ushort MessageId
    {
        get
        {
            return messageId;
        }
    }

    public MessageBase(ushort messageId)
    {
        this.messageId = messageId;
    }

    public ManagerId GetManager()
    {
        return (ManagerId)((int)(messageId / span) * span);
    }
}
