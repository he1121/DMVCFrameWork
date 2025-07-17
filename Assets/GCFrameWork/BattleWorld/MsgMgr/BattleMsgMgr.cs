using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GC.Battle
{
    public class BattleMsgMgr : IMsgBehaviour
    {
        public void OnCreate()
        {
            Debug.Log("BattleMsgMgr OnCreate>>>>>>");
        }

        public void OnDestroy()
        {
            Debug.Log("BattleMsgMgr OnDestroy>>>>>>");
        }
    }
}
