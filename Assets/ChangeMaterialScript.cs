using UnityEngine;

public class ChangeMaterialScript : MonoBehaviour
{
    public Material[] material;
    public MeshRenderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend.sharedMaterial = material[0];
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.collider.CompareTag("screwable"))
        {
            rend.sharedMaterial = material[1];
        }
    }
}