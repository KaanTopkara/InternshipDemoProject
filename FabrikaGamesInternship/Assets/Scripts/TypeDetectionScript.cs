using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeDetectionScript : MonoBehaviour
{
    public static int WoodType = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Type_1")
        {
            WoodType = 0;            
        }
        else if (collision.gameObject.tag == "Type_2")
        {
            WoodType = 1;          
        }
        else if (collision.gameObject.tag == "Type_3")
        {
            WoodType = 2;      
        }
    }
}
