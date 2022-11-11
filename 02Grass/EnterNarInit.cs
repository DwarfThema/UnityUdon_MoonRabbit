
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class EnterNarInit : UdonSharpBehaviour
{
    float lerpTime;
    public GameObject nar;
    void Start()
    {
        
    }

    void Update(){
        //transform.Rotate(Vector3.forward * Time.deltaTime * 30f);

        lerpTime += Time.deltaTime * 1.5f;
        float upDown = (Mathf.Sin(lerpTime)) * 0.0009f;

        transform.position += new Vector3(0, upDown, 0);

    }

    public void NarInit(){
        nar.SetActive(true);
    }
}
