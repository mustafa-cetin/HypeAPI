using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HypeAPI
{
    public class ModAPI
    {
        private readonly INPCManager _npcManager;

        public ModAPI(INPCManager npcManager)
        {
            _npcManager = npcManager;
        }

        public INPC CreateNPC(string name, Vector3 position, float health)
        {
            return _npcManager.CreateNPC(name, position, health);
        }

    }

}
