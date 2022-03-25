// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputSystemManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystemManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemManager"",
    ""maps"": [
        {
            ""name"": ""Jogador"",
            ""id"": ""96baabe3-24ea-4d16-8c8c-2e4f603ceb28"",
            ""actions"": [
                {
                    ""name"": ""Movimento"",
                    ""type"": ""Value"",
                    ""id"": ""346476d5-5ba2-410d-97a9-411147c6e3e1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pulo"",
                    ""type"": ""Button"",
                    ""id"": ""28897a07-2a04-4410-a1f8-49e9eadc6ff4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direção"",
                    ""id"": ""5c61da56-0a08-4020-ae5d-593c57cfe9fb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c3d81bf2-b9b0-42d4-a5f3-34b795eb498a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4d3549b4-151c-4993-948a-e4f7cad3bb72"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""61929ae3-9d1a-42c6-b0e5-e044c4ec2eea"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4a0aba2b-94f9-423a-a759-fcf0612ff85c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Setas"",
                    ""id"": ""2f57f4e4-8ebb-44ea-a05a-7afa442bbd34"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3c845f63-0cd8-4e76-8075-1f59ecc0eab2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3c86251b-8fd5-43be-a1b3-565fb8e21526"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c09d8d46-f088-47bd-b037-f9c320cae420"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6c18422f-c59c-4a73-bab7-3912ac989763"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f8205aed-a0d9-4d12-a2cf-c201ef424c58"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jogador
        m_Jogador = asset.FindActionMap("Jogador", throwIfNotFound: true);
        m_Jogador_Movimento = m_Jogador.FindAction("Movimento", throwIfNotFound: true);
        m_Jogador_Pulo = m_Jogador.FindAction("Pulo", throwIfNotFound: true);
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

    // Jogador
    private readonly InputActionMap m_Jogador;
    private IJogadorActions m_JogadorActionsCallbackInterface;
    private readonly InputAction m_Jogador_Movimento;
    private readonly InputAction m_Jogador_Pulo;
    public struct JogadorActions
    {
        private @InputSystemManager m_Wrapper;
        public JogadorActions(@InputSystemManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimento => m_Wrapper.m_Jogador_Movimento;
        public InputAction @Pulo => m_Wrapper.m_Jogador_Pulo;
        public InputActionMap Get() { return m_Wrapper.m_Jogador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JogadorActions set) { return set.Get(); }
        public void SetCallbacks(IJogadorActions instance)
        {
            if (m_Wrapper.m_JogadorActionsCallbackInterface != null)
            {
                @Movimento.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Pulo.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPulo;
                @Pulo.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPulo;
                @Pulo.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPulo;
            }
            m_Wrapper.m_JogadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimento.started += instance.OnMovimento;
                @Movimento.performed += instance.OnMovimento;
                @Movimento.canceled += instance.OnMovimento;
                @Pulo.started += instance.OnPulo;
                @Pulo.performed += instance.OnPulo;
                @Pulo.canceled += instance.OnPulo;
            }
        }
    }
    public JogadorActions @Jogador => new JogadorActions(this);
    public interface IJogadorActions
    {
        void OnMovimento(InputAction.CallbackContext context);
        void OnPulo(InputAction.CallbackContext context);
    }
}
