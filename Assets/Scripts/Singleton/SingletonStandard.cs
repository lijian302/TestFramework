using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonStandard : SingletonBaseStandard<SingletonStandard>
{
    private SingletonStandard() { }

    public void Init()
    {
        Debug.Log("SingletonStandardInit");
    }
}
