
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class CompleteBoard : UdonSharpBehaviour
{

    public AudioSource completeBoardAudio;
    private BoxCollider completeBoardCollider;
    [SerializeField] GameObject nar;


        void Start()
    {   

        completeBoardCollider = this.GetComponent<BoxCollider>();
    }

        void Update() {
        if (completeBoardAudio.isPlaying) {
            completeBoardCollider.enabled = false;
        } else {
            completeBoardCollider.enabled = true;
        }
    }

    public void completeBoardAnim(){
        nar.SetActive(true);
    }

    
}
