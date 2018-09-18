using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SingletonProperty<T> where T : class
{
    private static readonly object lockObj = new object();
    private static T instance;
    public static T Instance
    {
        get
        {
            lock (lockObj)
                if (instance == null)
                    instance = SingletonCreator.CreateSingleton<T>();
            return instance;
        }
    }

    public static void Dispose()
    {
        instance = null;
    }
}
