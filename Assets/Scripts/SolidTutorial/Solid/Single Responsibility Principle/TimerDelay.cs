using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SOLID.SingleResponsibility
{
    public class TimerDelay : MonoBehaviour
    {

        [SerializeField]
        private float duration = 1f;
        [SerializeField]
        private UnityEvent OnTimerEnd = new UnityEvent();
        [SerializeField]
        private bool detonateOnDestroy = false;

        private void Start() => StartCoroutine(StartTimer());

        public void Detonate()
        {
            OnTimerEnd?.Invoke();
            StopAllCoroutines();
        }

        private void OnDestroy()
        {
            if(detonateOnDestroy)
            {
                OnTimerEnd?.Invoke();
            }
        }

        private IEnumerator StartTimer()
        {
            yield return new WaitForSeconds(duration);
            OnTimerEnd?.Invoke();

        }
    }

}