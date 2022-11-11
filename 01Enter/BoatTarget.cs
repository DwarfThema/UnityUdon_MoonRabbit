
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3;

public class BoatTarget : UdonSharpBehaviour
{
    public GameObject boat;
    public GameObject Orb;
    public Animator boatAnim;

    void Start()
    {
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "_Boat"){
            Orb.SetActive(true);
            boatAnim.enabled = false;
            gameObject.SetActive(false);
        }
    }
}
