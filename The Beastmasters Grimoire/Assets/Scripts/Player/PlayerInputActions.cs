//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a6b40a50-24e9-433f-88ea-980fc02e9976"",
            ""actions"": [
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""561479d5-2216-4bb6-a5cc-1a3994a582ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GameMenu"",
                    ""type"": ""Button"",
                    ""id"": ""5b617571-927d-490a-95c1-c4b76f5b50f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""7e7833ef-6293-4f89-8731-ba5ece4daeb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpellcastMode"",
                    ""type"": ""Button"",
                    ""id"": ""c875e3c1-e491-49b8-970c-5c0c42157217"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""c72d9ea6-b202-4475-98d4-37599ceacd02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""b71ffa58-6d0d-4734-9a84-936cd1446caa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CaptureMode"",
                    ""type"": ""Button"",
                    ""id"": ""8594e4cb-f502-4852-b486-5cefdf18393b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""bbbadf05-f360-4c8b-b11d-222d36ee2547"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MonsterSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""d5aba842-56aa-47ef-a34b-b82591be351f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MonsterSelect"",
                    ""type"": ""Value"",
                    ""id"": ""4864c6e0-9613-4153-9aa0-3db5c696664b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Mobility"",
                    ""type"": ""Button"",
                    ""id"": ""8dce4ef2-a600-46b6-9a5f-e6fc5fbad601"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""53574366-615f-444e-a22e-88e164a49362"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1998379-ebe5-4a0a-b192-b98a6c8a1b51"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GameMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8e88ef0-1e9c-4a5d-a4cc-656c80ee5f63"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dda98993-f9ac-4419-b81d-44b943cfa77e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SpellcastMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa5d3990-96dd-418b-871b-16044713805c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""770d0a5a-f02f-49c9-80ed-ea0aac07e4ce"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6a7aff4-d9f0-4913-b1c7-063206ef9a8e"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CaptureMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f2758516-2e68-448f-8422-c5127fafb11a"",
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
                    ""id"": ""2882d7fe-d675-4f27-aa1e-26217c3369be"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""82d7f799-4d8a-4579-bd90-2b09fa4dfd86"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c3b1788-e0a8-49a9-aa6b-a1a23372ded1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2545e654-4012-4427-b848-ea7ab0d3616c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cd3b8c3c-3c70-4c6d-af91-49c4231088d2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MonsterSwitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c1176c27-cf7f-498f-b082-d0ad404ea8f5"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8ca58682-8578-4a4c-ad87-f0df5af9e59d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a2038ed6-3130-48b2-9886-fa40899d6a6e"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd3f9d3f-23e3-4e35-8f97-c52af23f5da8"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b87a9370-e019-4839-86c3-542dae61b863"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=3)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba052bcf-4ec7-49e2-9aa2-0221a1938d95"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=4)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffa1230f-a857-4810-be41-97b398584bb6"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=5)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c6197d6-5e5d-4e11-acd3-1dc9f8754a68"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=6)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34daa1e9-bfbc-4761-820c-328271082268"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=7)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7900dc0e-2074-4a09-b54e-a36cb42dd46c"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=8)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ba8133d-15f9-4146-bad1-2a3a46da254b"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=9)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15bea280-0c50-4d52-b254-e7270daf5f0e"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Scale(factor=10)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MonsterSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b394db80-7956-48e5-9815-7c163110bc5d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Mobility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PauseMenu = m_Player.FindAction("PauseMenu", throwIfNotFound: true);
        m_Player_GameMenu = m_Player.FindAction("GameMenu", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_SpellcastMode = m_Player.FindAction("SpellcastMode", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_CaptureMode = m_Player.FindAction("CaptureMode", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_MonsterSwitch = m_Player.FindAction("MonsterSwitch", throwIfNotFound: true);
        m_Player_MonsterSelect = m_Player.FindAction("MonsterSelect", throwIfNotFound: true);
        m_Player_Mobility = m_Player.FindAction("Mobility", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_PauseMenu;
    private readonly InputAction m_Player_GameMenu;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_SpellcastMode;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_CaptureMode;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_MonsterSwitch;
    private readonly InputAction m_Player_MonsterSelect;
    private readonly InputAction m_Player_Mobility;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseMenu => m_Wrapper.m_Player_PauseMenu;
        public InputAction @GameMenu => m_Wrapper.m_Player_GameMenu;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @SpellcastMode => m_Wrapper.m_Player_SpellcastMode;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @CaptureMode => m_Wrapper.m_Player_CaptureMode;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @MonsterSwitch => m_Wrapper.m_Player_MonsterSwitch;
        public InputAction @MonsterSelect => m_Wrapper.m_Player_MonsterSelect;
        public InputAction @Mobility => m_Wrapper.m_Player_Mobility;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @PauseMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @GameMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @GameMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @GameMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGameMenu;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @SpellcastMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpellcastMode;
                @SpellcastMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpellcastMode;
                @SpellcastMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpellcastMode;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @CaptureMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCaptureMode;
                @CaptureMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCaptureMode;
                @CaptureMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCaptureMode;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @MonsterSwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMonsterSwitch;
                @MonsterSwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMonsterSwitch;
                @MonsterSwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMonsterSwitch;
                @MonsterSelect.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMonsterSelect;
                @MonsterSelect.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMonsterSelect;
                @MonsterSelect.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMonsterSelect;
                @Mobility.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMobility;
                @Mobility.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMobility;
                @Mobility.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMobility;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @GameMenu.started += instance.OnGameMenu;
                @GameMenu.performed += instance.OnGameMenu;
                @GameMenu.canceled += instance.OnGameMenu;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @SpellcastMode.started += instance.OnSpellcastMode;
                @SpellcastMode.performed += instance.OnSpellcastMode;
                @SpellcastMode.canceled += instance.OnSpellcastMode;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @CaptureMode.started += instance.OnCaptureMode;
                @CaptureMode.performed += instance.OnCaptureMode;
                @CaptureMode.canceled += instance.OnCaptureMode;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MonsterSwitch.started += instance.OnMonsterSwitch;
                @MonsterSwitch.performed += instance.OnMonsterSwitch;
                @MonsterSwitch.canceled += instance.OnMonsterSwitch;
                @MonsterSelect.started += instance.OnMonsterSelect;
                @MonsterSelect.performed += instance.OnMonsterSelect;
                @MonsterSelect.canceled += instance.OnMonsterSelect;
                @Mobility.started += instance.OnMobility;
                @Mobility.performed += instance.OnMobility;
                @Mobility.canceled += instance.OnMobility;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnGameMenu(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSpellcastMode(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCaptureMode(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnMonsterSwitch(InputAction.CallbackContext context);
        void OnMonsterSelect(InputAction.CallbackContext context);
        void OnMobility(InputAction.CallbackContext context);
    }
}
