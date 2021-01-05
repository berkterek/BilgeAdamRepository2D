using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BilgeAdam2D.Abstracts.Movements
{
    public interface IMover
    {
        void MoveAction(float horizontal, float moveSpeed);
    }    
}

