using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField]
        private new string name = "Name";
        [SerializeField]
        private string description = "Description";

        public string Name => name;
        public string Description => description;

        public abstract void DisplayText();
    }
}
