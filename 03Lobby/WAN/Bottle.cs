
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Bottle : UdonSharpBehaviour
{

    Animator anim;
    public GameObject rabbitA;
    public GameObject wishPaper;
    public GameObject board;
    public AudioSource bottleAudio;



    void Start()
    {
        gameObject.SetActive(false);
        anim = GetComponent<Animator>();
        anim.enabled = false;

    }


    public override void Interact()
    {
        anim.enabled = true;
    }

    public void Drink()
    {

    }

    public void Done()
    {
        rabbitA.gameObject.SetActive(true);
        wishPaper.gameObject.SetActive(true);
        board.gameObject.SetActive(true);
        bottleAudio.enabled = true;
        gameObject.SetActive(false);
    }
}
