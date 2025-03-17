using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Clicker : MonoBehaviour
{
    private Controls _controls;

    public UnityEvent onClickUnity;
    public event Action OnClickEvent;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void OnEnable()
    {
        _controls.Player.Click.Enable();
        _controls.Player.Click.started += OnClick;
    }

    private void OnDisable()
    {
        _controls.Player.Click.started -= OnClick;
        _controls.Player.Click.Disable();
    }

    private void OnClick(InputAction.CallbackContext context)
    {
        onClickUnity?.Invoke();
        OnClickEvent?.Invoke();
        
        ClickPerformed();
        
    }

    public void ClickPerformed()
    {
        
    }
    
}
