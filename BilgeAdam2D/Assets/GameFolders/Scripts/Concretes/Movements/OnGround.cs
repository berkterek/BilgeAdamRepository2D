using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BilgeAdam2D.Movements
{
    public class OnGround : MonoBehaviour
    {
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private float _distance;
        [SerializeField] private bool _isOnGround;
        [SerializeField] private Transform[] _transforms;

        public bool IsOnGround => _isOnGround;

        private void Update()
        {
            foreach (Transform footTransform in _transforms)
            {
                _isOnGround = IsCharacterOnGround(footTransform);
                if (_isOnGround) break;
            }
        }

        private bool IsCharacterOnGround(Transform footTransform)
        {
            RaycastHit2D hit = Physics2D.Raycast(footTransform.position, footTransform.forward, _distance, _layerMask);
            
            Debug.DrawRay(footTransform.position,footTransform.forward * _distance,Color.red);

            if (hit.collider != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

