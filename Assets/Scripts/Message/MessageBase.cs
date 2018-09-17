using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理器Id
/// </summary>
public enum ManagerId
{
    UIManager = 0,
    GameManager = MessageBase.span,
    PlayerManager = MessageBase.span * 2
}

/// <summary>
/// UI消息Id
/// </summary>
public enum UIMessageId
{
    Message1 = ManagerId.UIManager,
    Message2,
    Message3
}

/// <summary>
/// Player消息Id
/// </summary>
public enum PlayerMessageId
{
    Message1 = ManagerId.PlayerManager,
    Message2,
    Message3
}

/// <summary>
/// 消息基类
/// </summary>
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

    /// <summary>
    /// 根据消息Id获取对应管理器
    /// </summary>
    /// <returns></returns>
    public ManagerId GetManager()
    {
        return (ManagerId)((int)(messageId / span) * span);
    }
}
