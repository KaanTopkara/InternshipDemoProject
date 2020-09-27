using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCuttedWood : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "TrashCan")
        {
            Destroy(this.gameObject, 2f);
        }
    }
    
}
