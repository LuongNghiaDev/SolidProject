using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion
{
    public interface IMovementInputGetter 
    {

        float Horizontal { get; }
        float Vertical { get; }
    }
}
