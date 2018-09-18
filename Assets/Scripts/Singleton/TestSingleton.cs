using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton
{
    private static TestSingleton instance;
    public static TestSingleton Instance
    {
        get
        {
            if (instance == null)
                instance = new TestSingleton();
            return instance;
        }
    }

    private TestSingleton() { }

    public void Init()
    {
        Debug.Log("TestSingletonInit");
    }
}
