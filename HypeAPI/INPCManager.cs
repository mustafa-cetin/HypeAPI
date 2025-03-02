using UnityEngine;

namespace HypeAPI
{
    public interface INPCManager
    {
        INPC CreateNPC(string name, Vector3 position, float health);
    }
}
