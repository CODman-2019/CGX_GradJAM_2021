// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions/PlayerCam.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerCam : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCam()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCam"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""33dd1298-de8f-42a7-ae8a-f8575acf4c7a"",
            ""actions"": [
                {
                    ""name"": ""mousePos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""944a6756-8756-479e-809f-d464db7dcf20"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49f510c4-3d6c-45c1-b61b-f1c25057d982"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""id"": ""5225d694-a173-48d5-85f4-508cb2eab0e4"",
            ""actions"": [
                {
                    ""name"": ""Left Stick"",
                    ""type"": ""Value"",
                    ""id"": ""0edd7185-301d-4d50-963e-b2f70e7df3c3"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Stick"",
                    ""type"": ""Value"",
                    ""id"": ""8185ebfa-7578-4870-9476-68b52219bb06"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0d0d7f18-9af5-4c5d-bb2a-048469af2d7e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c22ecbd7-fe44-4e8f-b669-2a0ac1557372"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_mousePos = m_Mouse.FindAction("mousePos", throwIfNotFound: true);
        // GamePad
        m_GamePad = asset.FindActionMap("GamePad", throwIfNotFound: true);
        m_GamePad_LeftStick = m_GamePad.FindAction("Left Stick", throwIfNotFound: true);
        m_GamePad_RightStick = m_GamePad.FindAction("Right Stick", throwIfNotFound: true);
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

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_mousePos;
    public struct MouseActions
    {
        private @PlayerCam m_Wrapper;
        public MouseActions(@PlayerCam wrapper) { m_Wrapper = wrapper; }
        public InputAction @mousePos => m_Wrapper.m_Mouse_mousePos;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @mousePos.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePos;
                @mousePos.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePos;
                @mousePos.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePos;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @mousePos.started += instance.OnMousePos;
                @mousePos.performed += instance.OnMousePos;
                @mousePos.canceled += instance.OnMousePos;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // GamePad
    private readonly InputActionMap m_GamePad;
    private IGamePadActions m_GamePadActionsCallbackInterface;
    private readonly InputAction m_GamePad_LeftStick;
    private readonly InputAction m_GamePad_RightStick;
    public struct GamePadActions
    {
        private @PlayerCam m_Wrapper;
        public GamePadActions(@PlayerCam wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStick => m_Wrapper.m_GamePad_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_GamePad_RightStick;
        public InputActionMap Get() { return m_Wrapper.m_GamePad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePadActions set) { return set.Get(); }
        public void SetCallbacks(IGamePadActions instance)
        {
            if (m_Wrapper.m_GamePadActionsCallbackInterface != null)
            {
                @LeftStick.started -= m_Wrapper.m_GamePadActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_GamePadActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_GamePadActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_GamePadActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_GamePadActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_GamePadActionsCallbackInterface.OnRightStick;
            }
            m_Wrapper.m_GamePadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
            }
        }
    }
    public GamePadActions @GamePad => new GamePadActions(this);
    public interface IMouseActions
    {
        void OnMousePos(InputAction.CallbackContext context);
    }
    public interface IGamePadActions
    {
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
    }
}
