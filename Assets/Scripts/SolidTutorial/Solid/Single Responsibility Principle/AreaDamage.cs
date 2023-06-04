using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{

    public class AreaDamage : MonoBehaviour
    {
        [SerializeField]
        private float explosionRadius = 5f;
        [SerializeField]
        private int damageToDeal = 10;

        public void Trigger()
        {
            
        }
    }
}
