using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMessageProcess
{
    void ProcessEvent(MessageBase message);
}
