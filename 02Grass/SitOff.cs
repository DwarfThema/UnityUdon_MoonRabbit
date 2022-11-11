
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SitOff : UdonSharpBehaviour
{
    public GameObject boatChair;
    VRC.SDK3.Components.VRCStation station;
    void Start()
    {
        station = (VRC.SDK3.Components.VRCStation)boatChair.GetComponent(typeof(VRC.SDK3.Components.VRCStation));
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name == "Orb"){
            station.disableStationExit = false;
            boatChair.SetActive(false);
        }

    }
}
