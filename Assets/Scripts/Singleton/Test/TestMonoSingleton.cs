using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoSingleton : MonoSingleton<TestMonoSingleton>
{
    public void Init()
    {
        Debug.Log("TestMonoSingletonInit");
    }
}
