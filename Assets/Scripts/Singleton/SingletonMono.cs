using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMono : SingletonMonoBase<SingletonMono>
{
    private SingletonMono() { }

    public void Init()
    {
        Debug.Log("SingletonMonoInit");
    }
}
