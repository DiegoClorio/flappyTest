//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Projects/Pools/Scripts/PlayerActions/PoolsPlayerInputActions.inputactions
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

public partial class @PoolsPlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PoolsPlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PoolsPlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Standard"",
            ""id"": ""adce114d-b889-4213-86e1-056a3c375f08"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f09241dd-001f-413b-9394-7fe5661d60d9"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a35ecfec-589e-41ff-a2c2-c06b13ca2a9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""16a38b67-f018-4002-af0e-1834241fde85"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""11526e1b-5dbf-42ae-adad-02c6b9cb5f4a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18055c0f-b251-4a5f-ae42-561703c624f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0c5515a1-9771-4662-8d98-cf8fe3172a45"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Standard
        m_Standard = asset.FindActionMap("Standard", throwIfNotFound: true);
        m_Standard_Movement = m_Standard.FindAction("Movement", throwIfNotFound: true);
        m_Standard_Shoot = m_Standard.FindAction("Shoot", throwIfNotFound: true);
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

    // Standard
    private readonly InputActionMap m_Standard;
    private IStandardActions m_StandardActionsCallbackInterface;
    private readonly InputAction m_Standard_Movement;
    private readonly InputAction m_Standard_Shoot;
    public struct StandardActions
    {
        private @PoolsPlayerInputActions m_Wrapper;
        public StandardActions(@PoolsPlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Standard_Movement;
        public InputAction @Shoot => m_Wrapper.m_Standard_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Standard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardActions set) { return set.Get(); }
        public void SetCallbacks(IStandardActions instance)
        {
            if (m_Wrapper.m_StandardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_StandardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public StandardActions @Standard => new StandardActions(this);
    public interface IStandardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
