
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PickupedPaper : UdonSharpBehaviour
{
    public GameObject prevPaper;
    public GameObject rabbit;

    void Start()
    {
        
    }

    private void Update() {
        if(rabbit.activeInHierarchy == true){
            gameObject.transform.position = prevPaper.transform.position;

        }
    }


}
