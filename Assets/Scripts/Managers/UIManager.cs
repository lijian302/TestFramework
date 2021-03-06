﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : ManagerBase
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UIManager();
            }
            return instance;
        }
    }

    public override ManagerId Id
    {
        get
        {
            return ManagerId.UIManager;
        }
    }

    private UIManager() { }
}
