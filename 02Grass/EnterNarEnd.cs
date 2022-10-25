
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class EnterNarEnd : UdonSharpBehaviour
{
    AudioSource enterAudioSource;
    public GameObject col;
    void Start()
    {
        enterAudioSource = GetComponent<AudioSource>();
    }
    private void Update() {
        if(enterAudioSource.isPlaying == false){
            col.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
