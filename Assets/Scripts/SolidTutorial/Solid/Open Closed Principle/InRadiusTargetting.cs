using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class InRadiusTargetting : MonoBehaviour, ITargetGetter
    {

        [SerializeField]
        private float radius = 10f;

        public List<Transform> GetTargets(Transform transform)
        {
            var targets = new List<Transform>();

            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

            foreach (var col in colliders)
            {
                targets.Add(col.transform);
            }
            return targets;
        }
    }
}
