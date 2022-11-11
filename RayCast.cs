
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class RayCast : UdonSharpBehaviour
{
    VRCPlayerApi player;
    Transform playerTransform;
    HumanBodyBones bone;
    GameObject btn;
    Image img;
    

    void Start()
    {
        
    }

    void Update() {


        gameObject.transform.position = Networking.LocalPlayer.GetBonePosition(HumanBodyBones.Head);
        gameObject.transform.rotation = Networking.LocalPlayer.GetBoneRotation(HumanBodyBones.Head);

        //Ray currentRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(transform.position, transform.forward, out hitInfo)){

            btn = hitInfo.transform.gameObject;
            img = (Image)btn.GetComponent(typeof(Image));

        }else{
        }

    }
}
