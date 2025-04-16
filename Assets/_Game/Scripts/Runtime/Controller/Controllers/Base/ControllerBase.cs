using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllerBase : MonoBehaviour
{
    public ControllerType controllerType;
    public abstract void Activate();
    public abstract void Deactivate();
}