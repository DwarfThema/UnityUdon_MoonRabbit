
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class BoatTarget : UdonSharpBehaviour
{
    public GameObject boat;
    public GameObject wisp;
    public Animator boatAnim;
    public GameObject boatChair;

    void Start()
    {

    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "_Boat"){
            wisp.SetActive(true);
            boatAnim.enabled = false;
            boatChair.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
