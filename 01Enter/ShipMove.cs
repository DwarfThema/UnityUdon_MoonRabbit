
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ShipMove : UdonSharpBehaviour
{
    public float speed;
    public GameObject targetPposition;

    void Start()
    {
        
    }

    void Update() {
        
        if(targetPposition != null && targetPposition.activeInHierarchy == true){
            
        transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPposition.transform.position, speed * Time.deltaTime);
        
        }


    }   
}
