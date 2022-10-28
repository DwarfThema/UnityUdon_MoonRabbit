
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GateOpen : UdonSharpBehaviour
{
    [SerializeField] Animator gate;
    [SerializeField] string param;
    [SerializeField] bool publicBool;


    private void OnTriggerEnter(Collider other) {

        if(other.gameObject.name == "Orb"){
            gate.SetBool(param, publicBool);
            gameObject.SetActive(false);
        }
    }
}
