using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingletonMono : MonoBehaviour
{
    private static TestSingletonMono instance;
    public static TestSingletonMono Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("TestSingletonMono");
                instance = go.AddComponent<TestSingletonMono>();
                DontDestroyOnLoad(go);
            }
            return instance;
        }
    }

    private TestSingletonMono() { }

    public void Init()
    {
        Debug.Log("TestSingletonMonoInit");
    }
}
