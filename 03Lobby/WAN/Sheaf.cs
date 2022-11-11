
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Sheaf : UdonSharpBehaviour
{
    public GameObject CompletedBoard;
    public GameObject nar;
    public GameObject rabbit;
    public GameObject magicRabbit;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CompletedBoard")
        {
            CompletedBoard.gameObject.SetActive(false);
            nar.SetActive(true);
            rabbit.SetActive(false);
            magicRabbit.SetActive(true);

        }

    }
}
