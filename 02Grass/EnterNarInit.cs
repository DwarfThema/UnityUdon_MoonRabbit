
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class EnterNarInit : UdonSharpBehaviour
{
    public GameObject nar;
    void Start()
    {
        
    }

    public void NarInit(){
        nar.SetActive(true);
    }
}
