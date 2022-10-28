
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayerAnimBool : UdonSharpBehaviour
{
    [SerializeField] Animator gate;
    [SerializeField] string param;
    [SerializeField] bool publicBool;

    VRCPlayerApi localPlayer;
    void Start()
    {
        localPlayer = Networking.LocalPlayer;
    }

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if(player.displayName == localPlayer.displayName){
            gate.SetBool(param, publicBool);
            gameObject.SetActive(false);
        }
    }
}
