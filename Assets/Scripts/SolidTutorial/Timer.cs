using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Example
{
    public class Timer : MonoBehaviour
    {
        public float remainingSeconds { get; private set; }

        public Timer(float duration)
        {
            remainingSeconds = duration;
        }

        public event Action OnTimerEnd;

        public void Tick(float deltaTime)
        {
            if(remainingSeconds == 0) { return; }

            remainingSeconds -= deltaTime;
            CheckForTimeEnd();
        }

        private void CheckForTimeEnd()
        {
            if(remainingSeconds > 0f) { return; }

            remainingSeconds = 0f;

            OnTimerEnd?.Invoke();
        }
    }
}
