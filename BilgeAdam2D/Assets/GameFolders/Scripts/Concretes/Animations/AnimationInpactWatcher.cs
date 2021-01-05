using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BilgeAdam2D.Animations
{
    public class AnimationInpactWatcher : MonoBehaviour
    {
        public event System.Action OnImpact;

        public void Impact()
        {
            OnImpact?.Invoke();
        }
    }    
}

