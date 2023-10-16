//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/Madeline Control.inputactions
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

public partial class @MadelineControl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MadelineControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Madeline Control"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""d8475c14-74a4-47a7-8ad3-b7e6d0ea5021"",
            ""actions"": [
                {
                    ""name"": ""horizontal move"",
                    ""type"": ""Value"",
                    ""id"": ""00767095-3d5b-493c-8bdb-9960a82a42fa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""06cd01f8-6cec-4f40-9a1e-d87d9ba0e6e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d8b2206a-8ac3-4e0e-a7d7-e3b576facc73"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontal move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""44d4a79b-7faa-41c1-a360-8f539181173b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Madeline Control"",
                    ""action"": ""horizontal move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""86dcf5d2-823e-4e72-ab67-3eb3233f4ba3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Madeline Control"",
                    ""action"": ""horizontal move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aa549a20-6981-41c3-9e86-2e75d85dd531"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Madeline Control"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Madeline Control"",
            ""bindingGroup"": ""Madeline Control"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_horizontalmove = m_gameplay.FindAction("horizontal move", throwIfNotFound: true);
        m_gameplay_Jump = m_gameplay.FindAction("Jump", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_gameplay_horizontalmove;
    private readonly InputAction m_gameplay_Jump;
    public struct GameplayActions
    {
        private @MadelineControl m_Wrapper;
        public GameplayActions(@MadelineControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @horizontalmove => m_Wrapper.m_gameplay_horizontalmove;
        public InputAction @Jump => m_Wrapper.m_gameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @horizontalmove.started += instance.OnHorizontalmove;
            @horizontalmove.performed += instance.OnHorizontalmove;
            @horizontalmove.canceled += instance.OnHorizontalmove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @horizontalmove.started -= instance.OnHorizontalmove;
            @horizontalmove.performed -= instance.OnHorizontalmove;
            @horizontalmove.canceled -= instance.OnHorizontalmove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    private int m_MadelineControlSchemeIndex = -1;
    public InputControlScheme MadelineControlScheme
    {
        get
        {
            if (m_MadelineControlSchemeIndex == -1) m_MadelineControlSchemeIndex = asset.FindControlSchemeIndex("Madeline Control");
            return asset.controlSchemes[m_MadelineControlSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnHorizontalmove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
