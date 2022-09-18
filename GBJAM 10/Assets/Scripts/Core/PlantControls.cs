// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Core/PlantControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlantControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlantControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlantControls"",
    ""maps"": [
        {
            ""name"": ""Grow"",
            ""id"": ""fb6fb131-b7fd-4409-ab6d-54fdbb37dbe7"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""46d626cb-229a-49c3-ba04-4c3684792063"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""f1a12994-8c59-4407-a6be-d79139a9c829"",
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
                    ""id"": ""23e3d516-1442-41ca-95ad-e3d6e14177fd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""88f0faad-29be-4c76-826f-052137dd7b56"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""fdb9b7b3-296a-48e0-9744-a0be2cdae3f4"",
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
                    ""id"": ""f059c2c7-5121-4fdc-b005-855dfcdbad92"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3a0a7144-12ca-4d95-8934-4ad73dc3eb90"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Grow
        m_Grow = asset.FindActionMap("Grow", throwIfNotFound: true);
        m_Grow_Move = m_Grow.FindAction("Move", throwIfNotFound: true);
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

    // Grow
    private readonly InputActionMap m_Grow;
    private IGrowActions m_GrowActionsCallbackInterface;
    private readonly InputAction m_Grow_Move;
    public struct GrowActions
    {
        private @PlantControls m_Wrapper;
        public GrowActions(@PlantControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Grow_Move;
        public InputActionMap Get() { return m_Wrapper.m_Grow; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GrowActions set) { return set.Get(); }
        public void SetCallbacks(IGrowActions instance)
        {
            if (m_Wrapper.m_GrowActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GrowActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GrowActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GrowActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GrowActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GrowActions @Grow => new GrowActions(this);
    public interface IGrowActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
