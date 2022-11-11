
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ConeAction : UdonSharpBehaviour
{
    [SerializeField] float rotateTime;
    void Start()
    {
        
    }
    
    void Update(){
        transform.Rotate(Vector3.down * -Time.deltaTime * rotateTime);

    }
}
