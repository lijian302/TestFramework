using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 处理消息接口
/// </summary>
public interface IMessageProcess
{
    void ProcessEvent(MessageBase message);
}
