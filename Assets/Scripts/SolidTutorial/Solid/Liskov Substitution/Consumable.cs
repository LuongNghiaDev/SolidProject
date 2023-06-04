using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.LiskovSubstitution
{

    public class Consumable : Item
    {
        [SerializeField]
        private string useText = "Consumable";

        public string UseText => useText;

        public override void DisplayText()
        {
            Debug.Log($"{Name} : Press E To {UseText}");
        }
    }
}
