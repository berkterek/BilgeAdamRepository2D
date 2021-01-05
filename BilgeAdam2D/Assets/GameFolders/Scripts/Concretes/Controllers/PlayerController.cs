using System;
using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Abstracts.Movements;
using BilgeAdam2D.Animations;
using BilgeAdam2D.Combats;
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
        CharacterAnimation _animation;
        Rigidbody2D _rigidbody;
        Attacker _attacker;
        
        float _horizantal;
        bool _canJump;
        bool _canAttack;

        private void Awake()
        {
            _input = new MyInput(new DefaultControl());
            _mover = new MoveRigidbody(this);
            _jump = new JumpRigidbody(this);
            _onGround = GetComponent<OnGround>();
            _flip = new Flip(this);
            _animation = new CharacterAnimation(this);
            _rigidbody = GetComponent<Rigidbody2D>();
            _attacker = GetComponent<Attacker>();
        }

        private void Update()
        {
            if (_input.IsAttack)
            {
                _canAttack = true;
            }
            
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

        private void LateUpdate()
        {
            _animation.MoveAnimation(_rigidbody.velocity.magnitude);

            if (_canAttack)
            {
                _animation.AttackAnimation();
            }

            _canAttack = false;
        }
    }    
}

