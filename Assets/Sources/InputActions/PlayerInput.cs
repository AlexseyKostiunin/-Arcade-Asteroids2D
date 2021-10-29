// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""67a45eaa-c6a9-4006-8525-c0ff5957ea45"",
            ""actions"": [
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""c4f268fe-480b-463c-aebc-c14eb75957eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""2a853173-b4ff-4c14-bdfe-8ff2ff3c6179"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootCanon"",
                    ""type"": ""Button"",
                    ""id"": ""d3e425c5-90ce-448e-b5b8-cfa1a54ab1c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLaser"",
                    ""type"": ""Button"",
                    ""id"": ""1355344a-edc7-412e-8b56-173b28d757cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb7a4a77-e50f-4574-aea9-f9fcb5366388"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""ShootCanon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""625a6414-887a-43e7-a5e8-82c0b261cf58"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""489b59ea-0043-4d99-9607-1e3f8fbfced2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""79c80d13-4793-4d8f-ad23-e4b55fc12ea7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""282d7b0b-7961-42e0-9f03-131122a1f755"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfe6e668-e38a-4abb-b6af-a97d2c8b9576"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
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
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveForward = m_Player.FindAction("MoveForward", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_ShootCanon = m_Player.FindAction("ShootCanon", throwIfNotFound: true);
        m_Player_ShootLaser = m_Player.FindAction("ShootLaser", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveForward;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_ShootCanon;
    private readonly InputAction m_Player_ShootLaser;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveForward => m_Wrapper.m_Player_MoveForward;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @ShootCanon => m_Wrapper.m_Player_ShootCanon;
        public InputAction @ShootLaser => m_Wrapper.m_Player_ShootLaser;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveForward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveForward;
                @MoveForward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveForward;
                @MoveForward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveForward;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @ShootCanon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootCanon;
                @ShootCanon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootCanon;
                @ShootCanon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootCanon;
                @ShootLaser.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLaser;
                @ShootLaser.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLaser;
                @ShootLaser.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLaser;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ShootCanon.started += instance.OnShootCanon;
                @ShootCanon.performed += instance.OnShootCanon;
                @ShootCanon.canceled += instance.OnShootCanon;
                @ShootLaser.started += instance.OnShootLaser;
                @ShootLaser.performed += instance.OnShootLaser;
                @ShootLaser.canceled += instance.OnShootLaser;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoveForward(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShootCanon(InputAction.CallbackContext context);
        void OnShootLaser(InputAction.CallbackContext context);
    }
}
