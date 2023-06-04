using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SOLID.SingleResponsibility
{

    public class TriggerOverLap : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent OnTrigger = new UnityEvent();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                OnTrigger?.Invoke();
            }
        }
    }
}
