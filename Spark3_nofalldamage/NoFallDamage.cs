using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using HarmonyLib;

namespace Spark3_nofalldamage
{
    public class NoFallDamage : MelonMod
    {
        int test;
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
            GameObject player_Fark = GameObject.Find("Player_Fark");
            if (player_Fark == null)
            {
                test = 0;
            }
            else
            {
                test = 1;
            }
            }

        public override void OnUpdate()
        {
            if (test==1) {
                HurtControl hurtControl = GameObject.Find("Player_Fark").GetComponent<HurtControl>();
                if (hurtControl.FallDamageCounter > 2)
                {
                    hurtControl.FallDamageCounter = 2;
                }
            }
        }

    }
}
