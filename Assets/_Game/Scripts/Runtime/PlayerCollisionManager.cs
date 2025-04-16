
using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerSwitcher.Instance.nearCar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerSwitcher.Instance.nearCar = false;
        
    }
}
