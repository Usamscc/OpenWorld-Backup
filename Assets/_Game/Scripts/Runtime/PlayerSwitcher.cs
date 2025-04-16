using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerSwitcher : MonoBehaviour
{
    public static PlayerSwitcher Instance;
    [SerializeField] private GameObject[] invectorComponents;
    [SerializeField] private GameObject[] rccComponents;

    [SerializeField]
    private RCC_CarControllerV3 CarControl;

    [SerializeField] private bool isInCar;
    public bool nearCar;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        if (isInCar && Input.GetKeyDown(KeyCode.E))
        {
            foreach (var comp in rccComponents)
            {
                comp.SetActive(false);
            }

            foreach (var comp in invectorComponents)
            {
                comp.SetActive(true);
            }

            CarControl.GetComponent<RCC_CarControllerV3>().enabled = false;
        }else if (!isInCar && nearCar && Input.GetKeyDown(KeyCode.E))
        {
            switchWithCar();
        }
    }

    private void switchWithCar()
    {
       
        foreach (var comp in rccComponents)
        {
            comp.SetActive(true);
        }
        foreach (var comp in invectorComponents)
        {
            comp.SetActive(false);
        }

        CarControl.GetComponent<RCC_CarControllerV3>().enabled = true;
        isInCar = true;
    }
    
}
