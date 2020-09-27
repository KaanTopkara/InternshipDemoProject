using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingWoodDestroy : MonoBehaviour
{
    public GameObject WholeWood;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "SawWithCollider")
        {           
            Destroy(WholeWood, 0.1f);
        }
    }
}

