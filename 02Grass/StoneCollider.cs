
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class StoneCollider : UdonSharpBehaviour
{
    bool stone1 = true;
    bool stone2 = true;
    bool stone3 = true;
    bool stone4 = true;
    bool stone5 = true;
    bool grassTime = false;

    [SerializeField] GameObject narStone;
    [SerializeField] GameObject narGrass;


    private void Update()
    {
        if (!stone1 && !stone2 && !stone3 && !stone4 && !stone5 && !grassTime)
        {
            grassTime = true;
            narStone.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BarrierStone_1")
        {
            stone1 = true;
        }
        else if (other.gameObject.name == "BarrierStone_2")
        {
            stone2 = true;
        }
        else if (other.gameObject.name == "BarrierStone_3")
        {
            stone3 = true;
        }
        else if (other.gameObject.name == "BarrierStone_4")
        {
            stone4 = true;
        }
        else if (other.gameObject.name == "BarrierStone_5")
        {
            stone5 = true;
        }

        if (other.gameObject.name == "GlowingReed")
        {
            narGrass.SetActive(true);
            Debug.Log("여기서 토끼 상처 사라지면됨");
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "BarrierStone_1")
        {
            stone1 = false;
        }
        else if (other.gameObject.name == "BarrierStone_2")
        {
            stone2 = false;
        }
        else if (other.gameObject.name == "BarrierStone_3")
        {
            stone3 = false;
        }
        else if (other.gameObject.name == "BarrierStone_4")
        {
            stone4 = false;
        }
        else if (other.gameObject.name == "BarrierStone_5")
        {
            stone5 = false;
        }
    }

}
