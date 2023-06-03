using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlantController : MonoBehaviour
{
    private PlantControls controls = null;
    List<string> Controls = new List<string>()
    {
        "upArrow",
        "downArrow",
        "leftArrow",
        "rightArrow",
        "a",
        "b"
    };

    //values
    float moveSpeed = 20f;

    private void Awake()
    {
        controls = new PlantControls();
    }

    private void OnEnable()
    {
        controls.Enable();

        //move controls
        controls.Grow.Move.performed += ctx => React(ctx);
        controls.Grow.Water.performed += ctx => React(ctx);
        controls.Special.Shake.performed += ctx => React(ctx);
    }

    void React(InputAction.CallbackContext ctx)
    {
        Vector2 currentPosition = transform.position;
        float ctxValue = ctx.ReadValue<float>();

        switch (ctx.control.name)
        {
            case "upArrow":
                Debug.Log("up");
                break;
            case "downArrow":
                break;
            case "leftArrow":
                break;
            case "rightArrow":
                break;
            case "a":
                transform.position = new Vector2(currentPosition.x, 
                    currentPosition.y + ctxValue * moveSpeed * Time.deltaTime);
                break;
            case "b":
                break;
            default:
                break;
        }
    }

    void Special()
    {

    }

    private void OnDisable()
    {
        controls.Disable();


    }

}
