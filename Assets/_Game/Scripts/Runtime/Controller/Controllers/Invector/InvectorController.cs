
using UnityEngine;

public class InvectorController : ControllerBase
{

    [SerializeField] private GameObject player;
    public override void Activate()
    {
        player.SetActive(true);
        player.transform.position=new Vector3(ControllersManager.Instance.updatePlayerPosition.x, player.transform.position.y,ControllersManager.Instance.updatePlayerPosition.y);
        
    }

    public override void Deactivate()
    {
        player.SetActive(false);
    }
}
