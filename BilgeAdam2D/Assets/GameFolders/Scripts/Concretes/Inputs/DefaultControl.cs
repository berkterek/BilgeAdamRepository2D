// GENERATED AUTOMATICALLY FROM 'Assets/GameFolders/Scripts/Concretes/Inputs/DefaultControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace BilgeAdam2D.Inputs
{
    public class @DefaultControl : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultControl"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""dc8edadd-f74a-44bb-95f8-e11e314b640b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""50ab3764-f6ca-40f3-b92e-c4da37a53ef9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""79961c36-141c-4113-80ff-5b1d33d6da2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""507b1ed9-e7ae-4f6b-a16a-708660ce6693"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ADKeyboard"",
                    ""id"": ""c1bfcaba-ff5b-406c-8c68-b93c5e831fd1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""562a5ad6-3a3a-404b-82a4-ac82a303c744"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""227bfc7d-b5b8-4aaa-8a38-957d6d647433"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""d4858230-de1e-48b0-8400-17419615eece"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4b96bd69-d838-49f7-a690-aadd50261b6d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""74269ea6-e662-4c3f-872e-82fdf6c68899"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c41f8172-5120-4fce-b12a-12a9619558ab"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap(duration=0.01,pressPoint=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcbcbe01-7a6b-430f-8fb1-4ddb72e4cf1d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b36f5062-8b24-4efc-be3b-ee287a0f62aa"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap(duration=0.01,pressPoint=0.02)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerOnFoot
            m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
            m_PlayerOnFoot_Move = m_PlayerOnFoot.FindAction("Move", throwIfNotFound: true);
            m_PlayerOnFoot_Jump = m_PlayerOnFoot.FindAction("Jump", throwIfNotFound: true);
            m_PlayerOnFoot_Attack = m_PlayerOnFoot.FindAction("Attack", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // PlayerOnFoot
        private readonly InputActionMap m_PlayerOnFoot;
        private IPlayerOnFootActions m_PlayerOnFootActionsCallbackInterface;
        private readonly InputAction m_PlayerOnFoot_Move;
        private readonly InputAction m_PlayerOnFoot_Jump;
        private readonly InputAction m_PlayerOnFoot_Attack;
        public struct PlayerOnFootActions
        {
            private @DefaultControl m_Wrapper;
            public PlayerOnFootActions(@DefaultControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_PlayerOnFoot_Move;
            public InputAction @Jump => m_Wrapper.m_PlayerOnFoot_Jump;
            public InputAction @Attack => m_Wrapper.m_PlayerOnFoot_Attack;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnFootActions instance)
            {
                if (m_Wrapper.m_PlayerOnFootActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Attack.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnAttack;
                }
                m_Wrapper.m_PlayerOnFootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                }
            }
        }
        public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);
        public interface IPlayerOnFootActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
        }
    }
}
