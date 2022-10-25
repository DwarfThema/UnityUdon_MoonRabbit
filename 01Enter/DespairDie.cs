
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class DespairDie : UdonSharpBehaviour
{
    public GameObject dieParticle;

    void Start()
    {
        
    }

    public void DieDespair(){
        dieParticle.SetActive(true);
    }
}   
