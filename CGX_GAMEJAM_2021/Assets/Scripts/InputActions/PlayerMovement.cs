// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""KeyBoard"",
            ""id"": ""cb87cd2c-6660-4c57-b374-366305f8679d"",
            ""actions"": [
                {
                    ""name"": ""InputV"",
                    ""type"": ""Button"",
                    ""id"": ""1767f78e-b9ba-4471-80fc-20d1b2ca6949"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputH"",
                    ""type"": ""Button"",
                    ""id"": ""39542f61-1636-40db-9213-eb2a139a0ea4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""ba38ffc3-ef32-4428-a402-9ce2b65d505b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""aa02130d-98cd-4026-ba2f-0c0aba78502a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Vertical"",
                    ""id"": ""71f55cbc-2ef9-49f4-92eb-a651e165795a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""c7b1bb33-4ff8-4ae9-8556-d3a5aba6e6fc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""1952707e-c9ac-449e-96d5-da2b5e159790"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""deefcf66-3829-49e8-b822-a2dc36531984"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""75aa8ece-270d-4734-b8e2-18d655c33c74"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5a3c3d6b-47e7-4337-8299-d2bf6ddf5694"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""08b91a62-2ceb-4eaa-8d1b-bfe466be3fb9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""29fb2193-5b98-4cb8-b11d-84a5b4b43299"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyBoard
        m_KeyBoard = asset.FindActionMap("KeyBoard", throwIfNotFound: true);
        m_KeyBoard_InputV = m_KeyBoard.FindAction("InputV", throwIfNotFound: true);
        m_KeyBoard_InputH = m_KeyBoard.FindAction("InputH", throwIfNotFound: true);
        m_KeyBoard_Sprint = m_KeyBoard.FindAction("Sprint", throwIfNotFound: true);
        m_KeyBoard_Newaction = m_KeyBoard.FindAction("New action", throwIfNotFound: true);
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

    // KeyBoard
    private readonly InputActionMap m_KeyBoard;
    private IKeyBoardActions m_KeyBoardActionsCallbackInterface;
    private readonly InputAction m_KeyBoard_InputV;
    private readonly InputAction m_KeyBoard_InputH;
    private readonly InputAction m_KeyBoard_Sprint;
    private readonly InputAction m_KeyBoard_Newaction;
    public struct KeyBoardActions
    {
        private @PlayerMovement m_Wrapper;
        public KeyBoardActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @InputV => m_Wrapper.m_KeyBoard_InputV;
        public InputAction @InputH => m_Wrapper.m_KeyBoard_InputH;
        public InputAction @Sprint => m_Wrapper.m_KeyBoard_Sprint;
        public InputAction @Newaction => m_Wrapper.m_KeyBoard_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_KeyBoard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyBoardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyBoardActions instance)
        {
            if (m_Wrapper.m_KeyBoardActionsCallbackInterface != null)
            {
                @InputV.started -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnInputV;
                @InputV.performed -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnInputV;
                @InputV.canceled -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnInputV;
                @InputH.started -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnInputH;
                @InputH.performed -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnInputH;
                @InputH.canceled -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnInputH;
                @Sprint.started -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnSprint;
                @Newaction.started -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_KeyBoardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InputV.started += instance.OnInputV;
                @InputV.performed += instance.OnInputV;
                @InputV.canceled += instance.OnInputV;
                @InputH.started += instance.OnInputH;
                @InputH.performed += instance.OnInputH;
                @InputH.canceled += instance.OnInputH;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public KeyBoardActions @KeyBoard => new KeyBoardActions(this);
    public interface IKeyBoardActions
    {
        void OnInputV(InputAction.CallbackContext context);
        void OnInputH(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
