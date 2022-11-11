
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class DropRabbit : UdonSharpBehaviour
{
    public GameObject bottle;

    AudioSource appearAudio;

    private MeshCollider bottleCollider;

    void Start()
    {

        appearAudio = GetComponent<AudioSource>();
        bottleCollider = bottle.GetComponent<MeshCollider>();
    }

    void Update() {
        if (appearAudio.isPlaying) {
            bottleCollider.enabled = false;
        } else {
            bottleCollider.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Orb"){
            bottle.SetActive(true);
            appearAudio.enabled = true;
        }
    }
    
}
