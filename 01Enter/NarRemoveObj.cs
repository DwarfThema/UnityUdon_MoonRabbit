
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class NarRemoveObj : UdonSharpBehaviour
{
    public GameObject obj;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.name == "_Boat"){
            obj.SetActive(false);
            gameObject.SetActive(false);
        }

    }
}
