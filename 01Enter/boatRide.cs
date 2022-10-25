
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class boatRide : UdonSharpBehaviour
{
    public GameObject textPanelObject = null;
    public GameObject activatedWhenPlayerIsInVehicle = null;
    public GameObject vehicleBoundsBoxCollider = null;

    Vector3 lastFramePosition;
    Quaternion lastFrameRotation;
    Quaternion stationRotation;
    Vector3 stationMovement;

    Quaternion newPlayerRotation;
    Vector3 currentPlayerPosition;
    Vector3 newPlayerPosition;
    Collider vehicleCollider;
    VRCPlayerApi localPlayer;

    void Start()
    {
        localPlayer = Networking.LocalPlayer;
        lastFramePosition = transform.position;
        lastFrameRotation = transform.rotation;
        vehicleCollider = vehicleBoundsBoxCollider.GetComponent<Collider>();
        activatedWhenPlayerIsInVehicle.SetActive(false);
        textPanelObject.GetComponent<Text>().text = "Script loaded successfully";
    }

    private void Update() {
        currentPlayerPosition = localPlayer.GetPosition();
        textPanelObject.GetComponent<Text>().text = "x:"+currentPlayerPosition.x.ToString()+", y:"+ currentPlayerPosition.y.ToString() + ", z:" + currentPlayerPosition.z.ToString();
        if(vehicleCollider.bounds.Contains(currentPlayerPosition)) {
            textPanelObject.GetComponent<Text>().text = "player in station";
            activatedWhenPlayerIsInVehicle.SetActive(true);
            stationMovement = transform.position - lastFramePosition;
            stationRotation = transform.rotation * Quaternion.Inverse(lastFrameRotation);
            newPlayerPosition = currentPlayerPosition + stationMovement;
            newPlayerRotation = localPlayer.GetRotation() * Quaternion.Inverse(stationRotation);
            localPlayer.TeleportTo(newPlayerPosition, newPlayerRotation);
        }
        else
        {
            activatedWhenPlayerIsInVehicle.SetActive(false);
        }
        lastFramePosition = transform.position;
        lastFrameRotation = transform.rotation;
    }
}
