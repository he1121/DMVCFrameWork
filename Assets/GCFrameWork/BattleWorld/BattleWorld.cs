using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GC.Battle
{
    public class BattleWorld : World
    {
        public override void OnCreate()
        {
            base.OnCreate();
            Debug.Log("BattleWorld OnCreate>>>>>>");
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            Debug.Log("BattleWorld OnDestroy>>>>>>");
        }

        public override void OnDestroyPostProcess(object arg)
        {
            base.OnDestroyPostProcess(arg);
            Debug.Log("BattleWorld OnDestroyPostProcess>>>>>>");
        }
    }
}
