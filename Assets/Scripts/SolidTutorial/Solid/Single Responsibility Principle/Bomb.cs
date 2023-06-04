using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{

    public class Bomb : MonoBehaviour
    {

        [SerializeField]
        private float secondUntilDetonation = 3f;
        [SerializeField]
        private float explosionRadius = 5f;
        [SerializeField]
        private int damageToDeal = 10;

        private void Start()
        {
            StartCoroutine(TimerDelay());
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Enemy"))
            {
                collision.GetComponent<Enemy>().DealDamage(damageToDeal);
                Detonate();
            }
        }

        private void Detonate()
        {
            Destroy(gameObject);
        }

        IEnumerator TimerDelay()
        {
            yield return new WaitForSeconds(secondUntilDetonation);

            Detonate();
        }

    }
}
