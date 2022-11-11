
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class StarDorp : UdonSharpBehaviour
{
    [SerializeField] GameObject[] particleObj;
    ParticleSystem particle;
    [SerializeField] GameObject nar;
    [SerializeField] float dropDegree;

    float time = 5f;
    [SerializeField] float brokenTime;

    [SerializeField] GameObject moon;
    [SerializeField] GameObject moonBrokenParticle;

    bool triggerOn = false;

    void Start()
    {

    }

    void Update(){

        if(triggerOn == true){

        time += Time.deltaTime;

        if(time >= brokenTime){
            moon.SetActive(false);
            moonBrokenParticle.SetActive(true);
        }   
        }
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name == "_Boat"){
            nar.SetActive(true);

            for(int i = 0; i < particleObj.Length; i++){
                if(particleObj != null){
                    particle = (ParticleSystem)particleObj[i].GetComponent(typeof(ParticleSystem));
                    var main = particle.main;
                    main.gravityModifierMultiplier = dropDegree;
                }
            }

            triggerOn = true;
        }
    }

    
}
