
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WishPaper : UdonSharpBehaviour
{
    public GameObject rabbit;
    public GameObject pastPaper;
     AudioSource myAudio;
    void Start()
    {
        
    }

        public override void Interact(){
            pastPaper.gameObject.SetActive(true);
            rabbit.gameObject.SetActive(false);
            
    }
    
}
