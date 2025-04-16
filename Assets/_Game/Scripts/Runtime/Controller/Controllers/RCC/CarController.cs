
using System;
using UnityEngine;

public class CarController : ControllerBase
{
    public CarType carType;
    [SerializeField] private GameObject[] rccComponents;
    [SerializeField] RCC_CarControllerV3 carControl;

    [SerializeField]
    private GameObject camera;
    
    private bool isInCar = false;

    private void OnEnable()
    {
        camera.transform.position=ControllersManager.Instance.playerInvectorCamera.transform.position;
    }

    public override void Activate()
    {
       print("Car controller Activated");
        foreach (var var in rccComponents)
        {
            var.transform.position = ControllersManager.Instance.playerInvectorCamera.transform.position;
            var.gameObject.SetActive(true);
        }
        isInCar = true;
        carControl.enabled = true;
    }

    public override void Deactivate()
    {
         carControl.enabled = false;
         foreach (var var in rccComponents)
         {
             var.gameObject.SetActive(false);
         }
         isInCar = false;
         ControllersManager.Instance.updatePlayerPosition=new Vector2(gameObject.transform.position.x-2,gameObject.transform.position.z+1);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isInCar)
        {
            ControllersManager.Instance.ActivateController(ControllerType.Invector);
        }
        
    }
    
}




public enum CarType
{
    Chevrolet,
    Lamborghini,
    Porsche,
    Aventador,
    Agera,
    Bugatti
}