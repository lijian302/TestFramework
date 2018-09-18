using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : SingletonBase<Singleton>
{
    public void Init()
    {
        Debug.Log("SingletonInit");
    }
}
