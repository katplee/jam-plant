using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

enum Controls
{
    upArrow,
    downArrow,
    leftArrow,
    rightArrow,
    a,
    b
}

public class PlantController : MonoBehaviour
{
    private PlantControls controls = null;

    private void Awake()
    {
        controls = new PlantControls();
    }

    private void OnEnable()
    {
        controls.Enable();

        //move controls
        controls.Grow.Move.performed += ctx => React(ctx.control.name);
        controls.Grow.Water.performed += ctx => React(ctx.control.name);
        controls.Special.Shake.performed += ctx => React(ctx.control.name);
    }

    void React(string path)
    {
        Debug.Log(path);
    }

    void Special()
    {

    }

    private void OnDisable()
    {
        controls.Disable();


    }

}
