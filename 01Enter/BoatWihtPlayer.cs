
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;


public class BoatWihtPlayer : UdonSharpBehaviour
{
    VRCPlayerApi player;
    public GameObject orientation; 

    void Start()
    {
        player = Networking.LocalPlayer;
    }

    private void Update() {
        player.TeleportTo(transform.position, player.GetRotation());

        //Debug.Log(player.GetRotation());
        if(Vector3.Distance(orientation.transform.position, transform.position) <= 0){
            
            player.TeleportTo(transform.position, new Quaternion(0.5f,0.5f,0.5f,0.5f) );
        }

    }
}
