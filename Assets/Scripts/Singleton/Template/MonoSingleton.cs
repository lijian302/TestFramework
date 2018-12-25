﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    protected static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();

                if (FindObjectsOfType<T>().Length > 1)
                {
                    Debug.LogError("More than 1!");
                    return instance;
                }

                if (instance == null)
                {
                    string instanceName = typeof(T).Name;
                    GameObject instanceGO = GameObject.Find(instanceName);

                    if (instanceGO == null)
                        instanceGO = new GameObject(instanceName);

                    instance = instanceGO.AddComponent<T>();
                    DontDestroyOnLoad(instanceGO);
                }
            }
            return instance;
        }
    }

    protected virtual void OnDestroy()
    {
        instance = null;
    }
}
