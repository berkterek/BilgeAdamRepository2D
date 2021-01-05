using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Abstracts.Movements;
using BilgeAdam2D.Inputs;
using BilgeAdam2D.Movements;
using UnityEngine;

namespace BilgeAdam2D.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 5f;
        MyInput _input;
        IMover _mover;

        float _horizantal;

        private void Awake()
        {
            _input = new MyInput(new DefaultControl());
            _mover = new MoveRigidbody(this);
        }

        private void Update()
        {
            _horizantal = _input.Horizontal;
        }

        private void FixedUpdate()
        {
            _mover.MoveAction(_horizantal,_moveSpeed);
        }
    }    
}

