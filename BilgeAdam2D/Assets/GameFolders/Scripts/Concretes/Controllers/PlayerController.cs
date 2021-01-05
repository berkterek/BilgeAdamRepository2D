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
        [SerializeField] float _jumpForce = 150f;
        
        MyInput _input;
        IMover _mover;
        JumpRigidbody _jump;
        OnGround _onGround;
        Flip _flip;
        
        float _horizantal;
        bool _canJump;

        private void Awake()
        {
            _input = new MyInput(new DefaultControl());
            _mover = new MoveRigidbody(this);
            _jump = new JumpRigidbody(this);
            _onGround = GetComponent<OnGround>();
            _flip = new Flip(this);
        }

        private void Update()
        {
            _horizantal = _input.Horizontal;

            if (_input.IsJump)
            {
                _canJump = true;
            }
            
            _flip.SetDirection(_horizantal);
        }

        private void FixedUpdate()
        {
            _mover.MoveAction(_horizantal,_moveSpeed);

            if (_canJump && _onGround.IsOnGround)
            {
                _jump.JumpAction(_jumpForce);    
            }

            _canJump = false;
        }
    }    
}

