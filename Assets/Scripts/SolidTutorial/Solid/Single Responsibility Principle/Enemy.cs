using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class Enemy : MonoBehaviour
    {

        private int health = 100;

        public void DealDamage(int damage)
        {
            health = Mathf.Max(0, health - damage);
            if(health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
