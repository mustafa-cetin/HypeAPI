using System;

namespace HypeAPI
{
    public static class GameHooks
    {
        public static event Action OnGameStart;
        public static event Action OnStealSomething;

        public static void TriggerGameStart()
        {
            OnGameStart?.Invoke();
        }

        public static void TriggerStealSomething()
        {
            OnStealSomething?.Invoke();
        }
        public static void InvokeCustomEvent(Action eventAction)
        {
            eventAction?.Invoke();
        }
    }
}
