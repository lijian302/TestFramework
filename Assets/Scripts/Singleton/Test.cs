using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        TestSingleton.Instance.Init();
        TestSingletonMono.Instance.Init();
        Singleton.Instance.Init();
        SingletonStandard.Instance.Init();
        SingletonMono.Instance.Init();
        SingletonManager.Instance.Init();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
