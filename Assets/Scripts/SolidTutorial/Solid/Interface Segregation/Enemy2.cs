using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class Enemy2 : ICharacter, IDamageable
    {
        public string Name => throw new System.NotImplementedException();

        public int Health => throw new System.NotImplementedException();

        public int MaxHealth => throw new System.NotImplementedException();

        public int Maxhealth => throw new System.NotImplementedException();

        public void DealDamage(int damageToDeal)
        {
            
        }
    }
}
