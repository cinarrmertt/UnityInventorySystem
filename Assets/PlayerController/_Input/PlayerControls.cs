//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.8.1
//     from Assets/PlayerController/_Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine;

namespace MTProject.PlayerController
{
    public partial class @PlayerControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerLocomotionMap"",
            ""id"": ""f5d4e31d-3e4d-454f-bd15-6010e6668dd1"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""6efd7d4e-7a37-490e-b27d-49d5786dc230"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""1e615561-cbae-486c-9994-519b82906433"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""995496f6-133d-4c7b-a5ff-a7ec39634f5a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8683ac1f-b48c-4b21-ae12-08e79d243dc6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleWalk"",
                    ""type"": ""Button"",
                    ""id"": ""e71ca87d-b3eb-415d-9ca7-b50c98d78114"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d3a6a47f-6bab-4453-be1e-6ac26d875757"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5ca69f45-3968-48c6-b467-b664c51b5c31"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dbba1e17-7b6b-4e4c-a4c1-dac4520c55ee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2724d54e-7c46-440a-b67c-953784801ca2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7779bc31-2b47-43d1-a4d7-f539142934b3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""776792b6-16ad-4585-bbf9-b09d4ba5e113"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e04b8e63-0498-4b48-907b-2c9c17249096"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8da7fa6-a085-4cf7-8576-fb1888523f78"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05acef28-b783-4f92-83e7-e216c828c8d1"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerLocomotionMap
            m_PlayerLocomotionMap = asset.FindActionMap("PlayerLocomotionMap", throwIfNotFound: true);
            m_PlayerLocomotionMap_Movement = m_PlayerLocomotionMap.FindAction("Movement", throwIfNotFound: true);
            m_PlayerLocomotionMap_Look = m_PlayerLocomotionMap.FindAction("Look", throwIfNotFound: true);
            m_PlayerLocomotionMap_Sprint = m_PlayerLocomotionMap.FindAction("Sprint", throwIfNotFound: true);
            m_PlayerLocomotionMap_Jump = m_PlayerLocomotionMap.FindAction("Jump", throwIfNotFound: true);
            m_PlayerLocomotionMap_ToggleWalk = m_PlayerLocomotionMap.FindAction("ToggleWalk", throwIfNotFound: true);
        }

        ~@PlayerControls()
        {
            Debug.Assert(!m_PlayerLocomotionMap.enabled, "This will cause a leak and performance issues, PlayerControls.PlayerLocomotionMap.Disable() has not been called.");
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

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // PlayerLocomotionMap
        private readonly InputActionMap m_PlayerLocomotionMap;
        private List<IPlayerLocomotionMapActions> m_PlayerLocomotionMapActionsCallbackInterfaces = new List<IPlayerLocomotionMapActions>();
        private readonly InputAction m_PlayerLocomotionMap_Movement;
        private readonly InputAction m_PlayerLocomotionMap_Look;
        private readonly InputAction m_PlayerLocomotionMap_Sprint;
        private readonly InputAction m_PlayerLocomotionMap_Jump;
        private readonly InputAction m_PlayerLocomotionMap_ToggleWalk;
        public struct PlayerLocomotionMapActions
        {
            private @PlayerControls m_Wrapper;
            public PlayerLocomotionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_PlayerLocomotionMap_Movement;
            public InputAction @Look => m_Wrapper.m_PlayerLocomotionMap_Look;
            public InputAction @Sprint => m_Wrapper.m_PlayerLocomotionMap_Sprint;
            public InputAction @Jump => m_Wrapper.m_PlayerLocomotionMap_Jump;
            public InputAction @ToggleWalk => m_Wrapper.m_PlayerLocomotionMap_ToggleWalk;
            public InputActionMap Get() { return m_Wrapper.m_PlayerLocomotionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerLocomotionMapActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerLocomotionMapActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ToggleWalk.started += instance.OnToggleWalk;
                @ToggleWalk.performed += instance.OnToggleWalk;
                @ToggleWalk.canceled += instance.OnToggleWalk;
            }

            private void UnregisterCallbacks(IPlayerLocomotionMapActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Look.started -= instance.OnLook;
                @Look.performed -= instance.OnLook;
                @Look.canceled -= instance.OnLook;
                @Sprint.started -= instance.OnSprint;
                @Sprint.performed -= instance.OnSprint;
                @Sprint.canceled -= instance.OnSprint;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @ToggleWalk.started -= instance.OnToggleWalk;
                @ToggleWalk.performed -= instance.OnToggleWalk;
                @ToggleWalk.canceled -= instance.OnToggleWalk;
            }

            public void RemoveCallbacks(IPlayerLocomotionMapActions instance)
            {
                if (m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerLocomotionMapActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerLocomotionMapActions @PlayerLocomotionMap => new PlayerLocomotionMapActions(this);
        public interface IPlayerLocomotionMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnToggleWalk(InputAction.CallbackContext context);
        }
    }
}
