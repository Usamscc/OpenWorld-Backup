using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : ControllerBase
{
    public CarType carType;
    
    public override void Activate()
    {
        
    }

    public override void Deactivate()
    {
        
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