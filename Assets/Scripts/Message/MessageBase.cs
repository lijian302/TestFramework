using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理器Id
/// </summary>
public enum ManagerId
{
    UIManager = 0,
    PlayerManager = MessageBase.SPAN,
    GameManager = MessageBase.SPAN * 2
}

/// <summary>
/// UI消息Id
/// </summary>
public enum UIMessageId
{
    Message1 = ManagerId.UIManager,
    Message2,
    Message3,
    MaxValue
}

/// <summary>
/// Player消息Id
/// </summary>
public enum PlayerMessageId
{
    Message1 = ManagerId.PlayerManager,
    Message2,
    Message3,
    MaxValue
}

/// <summary>
/// 消息基类
/// </summary>
public class MessageBase
{
    public const int SPAN = 3000;
    public ushort MessageId { get; }

    public MessageBase(ushort messageId)
    {
        this.MessageId = messageId;
    }

    /// <summary>
    /// 根据消息Id获取对应管理器
    /// </summary>
    /// <returns></returns>
    public ManagerId GetManager()
    {
        return (ManagerId)((int)(MessageId / SPAN) * SPAN);
    }
}
