
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class BoatSitting : UdonSharpBehaviour
{
    VRCPlayerApi player;
    public GameObject orientation;
    public GameObject enterCol;

    void Start()
    {
        player = Networking.LocalPlayer;
    }

    private void Update()
    {
        Networking.LocalPlayer.UseAttachedStation();
        //player.TeleportTo(transform.position, player.GetRotation());

        if (Vector3.Distance(orientation.transform.position, transform.position) <= 0 || orientation == null)
        {
            gameObject.SetActive(false);
        }
    }
}
