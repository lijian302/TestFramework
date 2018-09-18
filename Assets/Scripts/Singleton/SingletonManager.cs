using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager
{
    public static SingletonManager Instance
    {
        get
        {
            return SingletonProperty<SingletonManager>.Instance;
        }
    }

    private SingletonManager() { }

    public void Init()
    {
        Debug.Log("SingletonManagerInit");
    }
}
