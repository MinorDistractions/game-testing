using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cubeMove : MonoBehaviour
{

    PlayerControlls controls;

    void Awake()
    {
        controls = new PlayerControlls();

        controls.Gameplay.Grow.performed += ctx => Grows();

        Debug.Log("Awoken");



    }

    void Grows()
    {
        transform.localScale *= 1.1f;
        Debug.Log("Grew 1.1");
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
        Debug.Log("Enabled");
    }
     void OnDisable()
    {
        controls.Gameplay.Disable();
        Debug.Log("Disabled");
    }

}
