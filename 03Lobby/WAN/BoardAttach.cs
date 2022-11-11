
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class BoardAttach : UdonSharpBehaviour
{

    AudioSource firstAttachMusic;

    public GameObject WishPaperA;
    public GameObject WishPaperB;
    public GameObject WishPaperC;
    public GameObject WishPaperD;
    public GameObject WishPaperE;
    public GameObject PieceA;
    public GameObject PieceB;
    public GameObject PieceC;
    public GameObject PieceD;
    public GameObject PieceE;

    public GameObject RabbitB;
    public GameObject RabbitC;
    public GameObject RabbitD;
    public GameObject RabbitE;


    public GameObject CompletedBoard;

    public GameObject Bottle;

    public GameObject completeBoardAudio;

    void Start()
    {
        firstAttachMusic = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "WishPaperA")
        {

            Bottle.SetActive(false);

            WishPaperA.gameObject.SetActive(false);

            PieceA.gameObject.SetActive(true);

            RabbitB.gameObject.SetActive(true);
            RabbitC.gameObject.SetActive(true);
            RabbitD.gameObject.SetActive(true);
            RabbitE.gameObject.SetActive(true);

            firstAttachMusic.enabled = true;

        }

        else if (other.gameObject.name == "WishPaperB")
        {
            WishPaperB.gameObject.SetActive(false);
            PieceB.gameObject.SetActive(true);
            RabbitB.gameObject.SetActive(false);

        }
        else if (other.gameObject.name == "WishPaperC")
        {
            WishPaperC.gameObject.SetActive(false);
            PieceC.gameObject.SetActive(true);
            RabbitC.gameObject.SetActive(false);

        }
        else if (other.gameObject.name == "WishPaperD")
        {
            WishPaperD.gameObject.SetActive(false);
            PieceD.gameObject.SetActive(true);
            RabbitD.gameObject.SetActive(false);

        }
        else if (other.gameObject.name == "WishPaperE")
        {
            WishPaperE.gameObject.SetActive(false);
            PieceE.gameObject.SetActive(true);
            RabbitE.gameObject.SetActive(false);

        }
    }

    void Update()
    {
        if (PieceA.activeSelf && PieceB.activeSelf && PieceC.activeSelf && PieceD.activeSelf && PieceE.activeSelf)
        {
            PieceA.gameObject.SetActive(false);
            PieceB.gameObject.SetActive(false);
            PieceC.gameObject.SetActive(false);
            PieceD.gameObject.SetActive(false);
            PieceE.gameObject.SetActive(false);

            gameObject.SetActive(false);
            CompletedBoard.gameObject.SetActive(true);
            completeBoardAudio.SetActive(true);
        }
    }
}
