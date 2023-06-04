using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.LiskovSubstitution
{

    public class Weapon : Item
    {

        [SerializeField]
        private string useText = "Weapon";

        public string UseText => useText;

        public override void DisplayText()
        {
            Debug.Log($"{Name} : Press E To {UseText}");
        }
    }
}
