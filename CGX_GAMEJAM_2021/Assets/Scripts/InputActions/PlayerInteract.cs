// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions/PlayerInteract.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInteract : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInteract()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInteract"",
    ""maps"": [
        {
            ""name"": ""Player_Input"",
            ""id"": ""86e9e412-7c68-4f7b-8e56-c04402d64a69"",
            ""actions"": [
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""632c49b8-dffc-44ac-b57e-d9c315c20e5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""34045bf7-ba4a-468d-993a-da2867b6529d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player_Input
        m_Player_Input = asset.FindActionMap("Player_Input", throwIfNotFound: true);
        m_Player_Input_Interaction = m_Player_Input.FindAction("Interaction", throwIfNotFound: true);
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

    // Player_Input
    private readonly InputActionMap m_Player_Input;
    private IPlayer_InputActions m_Player_InputActionsCallbackInterface;
    private readonly InputAction m_Player_Input_Interaction;
    public struct Player_InputActions
    {
        private @PlayerInteract m_Wrapper;
        public Player_InputActions(@PlayerInteract wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interaction => m_Wrapper.m_Player_Input_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_Player_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_InputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_InputActions instance)
        {
            if (m_Wrapper.m_Player_InputActionsCallbackInterface != null)
            {
                @Interaction.started -= m_Wrapper.m_Player_InputActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_Player_InputActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_Player_InputActionsCallbackInterface.OnInteraction;
            }
            m_Wrapper.m_Player_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
            }
        }
    }
    public Player_InputActions @Player_Input => new Player_InputActions(this);
    public interface IPlayer_InputActions
    {
        void OnInteraction(InputAction.CallbackContext context);
    }
}
