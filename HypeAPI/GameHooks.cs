using System;
using System.Collections.Generic;
using System.Text;

namespace HypeAPI
{
    public static class GameHooks
    {
        public static event Action OnGameStart;
        public static event Action OnStealSomething;
    }
}
