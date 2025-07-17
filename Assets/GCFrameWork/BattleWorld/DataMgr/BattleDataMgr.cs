using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GC.Battle
{
    public class BattleDataMgr : IDataBehaviour
    {
        public void OnCreate()
        {
            Debug.Log("BattleDataMgr OnCreate>>>>>>");
        }

        public void OnDestroy()
        {
            Debug.Log("BattleDataMgr OnDestroy>>>>>>");
        }
    }   
}
