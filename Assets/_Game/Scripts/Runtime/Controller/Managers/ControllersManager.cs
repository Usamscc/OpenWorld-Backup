using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllersManager : MonoBehaviour
{
    public static ControllersManager Instance;
    
    [field: SerializeField] public ControllerBase ActiveController { get; private set; }
    
    [Space]
    [Header("Controllers")]
    public ControllerBase[] controllers;

    public Camera playerInvectorCamera;
    
    [HideInInspector] public Vector2 updatePlayerPosition;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void ActivateController(ControllerType type)
    {
        DeactivateActiveController();

        for (int i = 0; i < controllers.Length; i++)
        {
            if (controllers[i].controllerType == type)
            {
                ActiveController = controllers[i];
                ActiveController.Activate();
                break;
            }
        }
    }

    public void ActivateController(CarController controller)
    {
        DeactivateActiveController();

        ActiveController = controller;
        ActiveController.Activate();
    }

    void DeactivateActiveController()
    {
        if (ActiveController != null)
            ActiveController.Deactivate();
        ActiveController = null;
    }
}