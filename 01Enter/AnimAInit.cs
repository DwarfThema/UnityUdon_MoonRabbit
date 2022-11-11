
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AnimAInit : UdonSharpBehaviour
{
    public GameObject doll;
    public string triggerObjAName;
    public Animator triggerObjA;
    public string triggerObjBName;
    public Animator triggerObjB;



    public string triggerDollsName;
    public Animator dollA;
    public Animator dollB;
    public Animator dollC;
    public Animator dollD;
    public Animator dollE;
    public Animator dollF;
    public Animator dollG;
    public Animator dollH;

    public GameObject stopObj;
    UdonBehaviour stop;
    void Start()
    {
        if (stopObj != null)
        {

            stop = (UdonBehaviour)stopObj.GetComponent(typeof(UdonBehaviour));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "_Boat")
        {

            if (stopObj != null)
            {
                stop.SendCustomEvent("Stop");
            }

            if (doll != null)
            {
                if (doll.activeInHierarchy == true)
                {
                    doll.SetActive(false);
                }
                else
                {
                    doll.SetActive(true);
                }
            }

            if (triggerObjA != null)
            {
                triggerObjA.SetTrigger(triggerObjAName);
            }

            if (triggerObjB != null)
            {
                triggerObjB.SetTrigger(triggerObjBName);
            }

            if (dollA != null && dollB != null && dollC != null && dollD != null && dollE != null && dollF != null && dollG != null && dollH != null)
            {
                dollA.SetTrigger(triggerDollsName);
                dollB.SetTrigger(triggerDollsName);
                dollC.SetTrigger(triggerDollsName);
                dollD.SetTrigger(triggerDollsName);
                dollE.SetTrigger(triggerDollsName);
                dollF.SetTrigger(triggerDollsName);
                dollG.SetTrigger(triggerDollsName);
                dollH.SetTrigger(triggerDollsName);
            }

            gameObject.SetActive(false);
        }
    }
}
