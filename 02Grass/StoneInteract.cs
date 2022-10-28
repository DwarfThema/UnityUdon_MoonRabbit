
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class StoneInteract : UdonSharpBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Interact()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
