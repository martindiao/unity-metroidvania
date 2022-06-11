//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Data/Settings/Input/InputActions.inputactions
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

namespace Metroidvania.InputSystem
{
    public partial class @InputActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""75d2c316-d2fd-4e89-b7b2-69931a79525b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6b7e5138-be16-4ab1-abef-905b7f054897"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1627e21b-361c-4c2b-9a5e-b26ea9b7352a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""0320aa6e-e643-4ed9-9736-5e860dc4c0bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""c70e95d4-9315-4983-adb6-04a0767e4401"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e373570f-e624-45dc-83b3-50c87a6cd77a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ebaacd31-fe14-494b-a603-6b6df21a5b3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b4413361-6e2d-46c9-8591-ab3bcb84506d"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d65adb53-a9a8-4f20-8d8c-808a8f294f25"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85c400d7-6ba1-47ff-8a36-dd5836ef2401"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40ab1b2f-950f-4134-80a6-ad326ad5af3d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18e815e0-91eb-4eff-bef5-48d6a326d497"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9dd4639-e082-4e31-a64b-61ef3c11bd7f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1d377e2-1ef1-473c-8189-ff6fe5b624f7"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a8b7b52-9c13-4d13-99cb-14d9e1987ef8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""f3d11f6f-e80f-4e07-a062-cdc537ee9a7e"",
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
                    ""id"": ""3c5f0302-7a27-4332-8545-8af34e8211fc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd941c2b-7ad9-47b5-ba76-d4835c9fb36c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a65dbb1d-38e2-4284-a477-a25436e221d9"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""084e8d8f-d3d5-4ee7-934a-d7aeeed1918d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eb9564a-5346-40d7-ab6b-11df8949ae90"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""8417705e-5146-497b-9975-c0ceffac3dad"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2de3f644-e82f-4d72-ade2-5c3858be70a4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""411bb47d-7aae-4514-933d-25151226c20f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""a7b1e7cd-a4a9-4a13-b667-37fed6ffbbd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e570c1c5-2e3a-4da8-a362-1b56ba89ee17"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4da43a4f-b52d-4596-b07b-51337611d401"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""82d93a3a-6fcb-49c3-8b56-f306a425f646"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""40438f43-796f-4966-b0dd-15d6ed1b2c49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c3d3417f-a46b-458b-8fda-d90d76954cea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""a5d7a23f-9f25-4fab-90a3-3f45268b108c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d55c9957-2f4b-4c83-9706-692ac278684a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""26529e7c-ed15-47c9-8cf6-c82c531a1a00"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3f1f42f3-f93d-4731-b0d2-e3346631c2bd"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""437ff226-586e-4408-99f9-da745d5d46c7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""06f69b30-56f9-4a49-8772-3de326fad326"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""09495b6e-79c0-4ed8-af20-8ba2d6bef245"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7957365b-4496-4992-8714-c987f3ab3758"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""87ec543e-dc89-4b9f-8fdb-d8be86e4f0e9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cbda958b-bcc2-4661-ac7e-962658f5c369"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e8ac4906-b3c5-49dd-9fd3-0d252e31ce8c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""129c72d4-e218-49bc-9ddc-16c557369327"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard & Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da530a3e-5f3b-4796-b8d6-53b7a85d30d0"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard & Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd7e4236-ad5c-438e-844e-af4e0c8b39f1"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb415b0f-b612-4202-acb5-daad6d39853f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13c6bc1a-72a4-45a6-97c8-516cbc0627ab"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9fd190-1862-4d3f-824d-b42b06f2443e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5311732-1180-400b-ba5d-6369fcf5ec58"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Keyboard & Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
            m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
            m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
            m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
            m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
            m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
            // Menus
            m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
            m_Menus_Navigate = m_Menus.FindAction("Navigate", throwIfNotFound: true);
            m_Menus_Submit = m_Menus.FindAction("Submit", throwIfNotFound: true);
            m_Menus_Cancel = m_Menus.FindAction("Cancel", throwIfNotFound: true);
            m_Menus_Point = m_Menus.FindAction("Point", throwIfNotFound: true);
            m_Menus_Click = m_Menus.FindAction("Click", throwIfNotFound: true);
            m_Menus_ScrollWheel = m_Menus.FindAction("ScrollWheel", throwIfNotFound: true);
            m_Menus_MiddleClick = m_Menus.FindAction("MiddleClick", throwIfNotFound: true);
            m_Menus_RightClick = m_Menus.FindAction("RightClick", throwIfNotFound: true);
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

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_Move;
        private readonly InputAction m_Gameplay_Jump;
        private readonly InputAction m_Gameplay_Dash;
        private readonly InputAction m_Gameplay_Crouch;
        private readonly InputAction m_Gameplay_Attack;
        private readonly InputAction m_Gameplay_Pause;
        public struct GameplayActions
        {
            private @InputActions m_Wrapper;
            public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Gameplay_Move;
            public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
            public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
            public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
            public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
            public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                    @Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    @Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    @Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    @Crouch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                    @Crouch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                    @Crouch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                    @Attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Dash.started += instance.OnDash;
                    @Dash.performed += instance.OnDash;
                    @Dash.canceled += instance.OnDash;
                    @Crouch.started += instance.OnCrouch;
                    @Crouch.performed += instance.OnCrouch;
                    @Crouch.canceled += instance.OnCrouch;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);

        // Menus
        private readonly InputActionMap m_Menus;
        private IMenusActions m_MenusActionsCallbackInterface;
        private readonly InputAction m_Menus_Navigate;
        private readonly InputAction m_Menus_Submit;
        private readonly InputAction m_Menus_Cancel;
        private readonly InputAction m_Menus_Point;
        private readonly InputAction m_Menus_Click;
        private readonly InputAction m_Menus_ScrollWheel;
        private readonly InputAction m_Menus_MiddleClick;
        private readonly InputAction m_Menus_RightClick;
        public struct MenusActions
        {
            private @InputActions m_Wrapper;
            public MenusActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Navigate => m_Wrapper.m_Menus_Navigate;
            public InputAction @Submit => m_Wrapper.m_Menus_Submit;
            public InputAction @Cancel => m_Wrapper.m_Menus_Cancel;
            public InputAction @Point => m_Wrapper.m_Menus_Point;
            public InputAction @Click => m_Wrapper.m_Menus_Click;
            public InputAction @ScrollWheel => m_Wrapper.m_Menus_ScrollWheel;
            public InputAction @MiddleClick => m_Wrapper.m_Menus_MiddleClick;
            public InputAction @RightClick => m_Wrapper.m_Menus_RightClick;
            public InputActionMap Get() { return m_Wrapper.m_Menus; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
            public void SetCallbacks(IMenusActions instance)
            {
                if (m_Wrapper.m_MenusActionsCallbackInterface != null)
                {
                    @Navigate.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnNavigate;
                    @Submit.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnSubmit;
                    @Cancel.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnCancel;
                    @Point.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnPoint;
                    @Click.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnClick;
                    @ScrollWheel.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnScrollWheel;
                    @MiddleClick.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnMiddleClick;
                    @RightClick.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnRightClick;
                }
                m_Wrapper.m_MenusActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @ScrollWheel.started += instance.OnScrollWheel;
                    @ScrollWheel.performed += instance.OnScrollWheel;
                    @ScrollWheel.canceled += instance.OnScrollWheel;
                    @MiddleClick.started += instance.OnMiddleClick;
                    @MiddleClick.performed += instance.OnMiddleClick;
                    @MiddleClick.canceled += instance.OnMiddleClick;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                }
            }
        }
        public MenusActions @Menus => new MenusActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IGameplayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
        }
        public interface IMenusActions
        {
            void OnNavigate(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnScrollWheel(InputAction.CallbackContext context);
            void OnMiddleClick(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
        }
    }
}
