using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class DamageDealer : MonoBehaviour
    {

        public void DamageTarget(Transform target, int damageToDeal)
        {
            var damageable = target.GetComponent<IDamageable>();

            if (damageable == null) { return; }

            damageable.DealDamage(damageToDeal);

            Debug.Log(damageable.Health);
        }
    }
}
