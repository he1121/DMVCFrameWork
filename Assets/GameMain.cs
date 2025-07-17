using System;
using System.Collections;
using System.Collections.Generic;
using GC.Battle;
using GC.Hall;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WorldManager.CreateWorld<HallWorld>();
        HallWorld.GetExistsLogicCtrl<HallLogicCtrl>().Test();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            WorldManager.CreateWorld<BattleWorld>();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            WorldManager.DestroyWorld<BattleWorld>();
        }
    }

    private void OnApplicationQuit()
    {
        WorldManager.DestroyWorld<HallWorld>();
    }
}
