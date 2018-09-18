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
                go.AddComponent<TestSingletonMono>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    private TestSingletonMono() { }

    public void Init()
    {
        Debug.Log("TestSingletonMonoInit");
    }
}
