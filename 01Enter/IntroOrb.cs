
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class IntroOrb : UdonSharpBehaviour
{
    [SerializeField] GameObject main;
    [SerializeField] GameObject side;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "IntroOrbTrigger"){
            ParticleSystem mainParticl = (ParticleSystem)main.GetComponent(typeof(ParticleSystem));
            ParticleSystem sideParticl = (ParticleSystem)side.GetComponent(typeof(ParticleSystem));

            int mainStartSize = mainParticl.main.maxParticles;
            int sideStartSize = sideParticl.main.maxParticles;

            while(mainStartSize >= 0 || sideStartSize >= 0){
                mainStartSize -= 1;
                sideStartSize -= 1;
                Debug.Log(mainStartSize);
            }
        }
    }
}
