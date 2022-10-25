
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GrassInteract : UdonSharpBehaviour
{

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name == "SickRabbit"){
            //이후에 setactive가 아닌 쉐이더 발동 뒤 destroy 하는 방식으로
        }
    }

}
