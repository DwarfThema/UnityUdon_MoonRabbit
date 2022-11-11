
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class DanceRotation : UdonSharpBehaviour
{
    public float speed;
    public float stopDurationTime;
    void Start()
    {

    }

    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    public void Stop(){
        
        while(speed >= 0){
            speed -= stopDurationTime;
        }
    }
}
