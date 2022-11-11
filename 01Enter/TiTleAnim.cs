
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TiTleAnim : UdonSharpBehaviour
{
    [SerializeField] GameObject particle1;
    [SerializeField] GameObject particle2;
    void Start()
    {
        
    }

    public void TitleParticle(){
        if(particle1!=null){
            particle1.SetActive(true);
        }
        if(particle2!=null){
            particle2.SetActive(true);
        }
    }
}
