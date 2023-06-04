using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface ICharacter
    {
        string Name { get; }
    }

    public interface IDamageable
    {
        int Health { get; }
        int Maxhealth { get; }
        void DealDamage(int damageDeal);
    }

    public interface IManaUser
    {
        int Mana { get; }
        int MaxMana { get; }
        void SpendMana(int manaToSpend);
    }

    public interface IMoveable
    {
        int Speed { get; }
        Vector3 Position { get; }
        void Move(Vector3 direction);
    }
}
