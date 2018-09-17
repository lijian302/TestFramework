using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoBase : MonoBehaviour
{
    public virtual void SendMessage(MessageBase message) { }
    public abstract void ProcessEvent(MessageBase message);
}
