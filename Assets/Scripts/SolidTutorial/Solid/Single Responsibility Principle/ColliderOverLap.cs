using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SOLID.SingleResponsibility
{
    public class ColliderOverLap : MonoBehaviour
    {

        [SerializeField]
        private UnityEvent OnCollider = new UnityEvent();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                OnCollider?.Invoke();
            }
        }
    }
}
