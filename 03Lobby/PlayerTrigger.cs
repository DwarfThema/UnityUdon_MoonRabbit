
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayerTrigger : UdonSharpBehaviour
{
    [SerializeField] GameObject[] obj;
    VRCPlayerApi localPlayer;
    void Start()
    {
        localPlayer = Networking.LocalPlayer;
    }

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if (player.displayName == localPlayer.displayName)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].activeInHierarchy == false)
                {
                    obj[i].SetActive(true);
                }
                else
                {
                    obj[i].SetActive(false);
                }
            }

            gameObject.SetActive(false);
        }
    }
}
