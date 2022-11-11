
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;  
using VRC.Udon;

public class BoatSitting : UdonSharpBehaviour
{
    VRCPlayerApi player;
    public GameObject orientation;
    VRCStation station;
    public GameObject enterCol;


    void Start()
    {
        player = Networking.LocalPlayer;
        station = (VRCStation)gameObject.GetComponent(typeof(VRCStation));
        station.disableStationExit = true;
        player.UseAttachedStation();
    }

    private void Update()
    {
        //player.TeleportTo(transform.position, player.GetRotation());
        if (Vector3.Distance(orientation.transform.position, transform.position) <= 0 || orientation == null)
        {
            gameObject.SetActive(false);
        }else{
            player.UseAttachedStation();
        }
    }
}
