using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{

    public class DestroyAction : MonoBehaviour
    {

        public void TriggerAtion() => Destroy(gameObject);
    }
}
