
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCollisionManager : MonoBehaviour
{

    private bool isCar;
    private CarController car;
  

    private void OnEnable()
    {
        isCar = false;
    }

    private void Update()
    {
        if (isCar && Input.GetKeyDown(KeyCode.E) && car!=null)
        {
            ControllersManager.Instance.ActivateController(car);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
     
        car = other.GetComponent<CarController>();
        if (car!=null)
        {
            isCar=true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        isCar=false;
        car = null;

    }
}
