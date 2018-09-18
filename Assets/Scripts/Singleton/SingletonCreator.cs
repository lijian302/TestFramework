using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public static class SingletonCreator
{
    public static T CreateSingleton<T>() where T : class
    {
        //获取私有构造方法
        ConstructorInfo[] constructors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
        //获取无参构造方法
        ConstructorInfo constructor = Array.Find(constructors, c => c.GetParameters().Length == 0);
        if (constructor == null)
        {
            throw new Exception(typeof(T) + "未找到私有无参构造方法");
        }
        return constructor.Invoke(null) as T;
    }
}
