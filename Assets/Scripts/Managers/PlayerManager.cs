using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : ManagerBase
{
    private static PlayerManager instance;
    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerManager();
            }
            return instance;
        }
    }

    public override ManagerId Id
    {
        get
        {
            return ManagerId.PlayerManager;
        }
    }

    private PlayerManager() : base() { }
}
