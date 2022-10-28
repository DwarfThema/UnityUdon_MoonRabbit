
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class StoneActive : UdonSharpBehaviour
{
    [SerializeField] GameObject stones;
    MeshCollider[] col;
    [SerializeField] GameObject nar;
    [SerializeField] GameObject stoneCol;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Orb")
        {
            stoneCol.SetActive(true);
            nar.SetActive(true);
            col = stones.GetComponentsInChildren<MeshCollider>();

            foreach (MeshCollider meshCol in col)
            {
                meshCol.enabled = true;
            }
        }
    }
}
