using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GC.Battle
{
    public class BattleLogicCtrl : ILogicBehaviour
    {
        public void OnCreate()
        {
            Debug.Log("BattleLogicCtrl OnCreate>>>>>>");
        }

        public void OnDestroy()
        {
            Debug.Log("BattleLogicCtrl OnDestroy>>>>>>");
        }
    }   
}
