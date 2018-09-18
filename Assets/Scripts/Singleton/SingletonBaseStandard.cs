using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonBaseStandard<T> where T : SingletonBaseStandard<T>
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

    protected virtual void Dispose()
    {
        instance = null;
    }
}
