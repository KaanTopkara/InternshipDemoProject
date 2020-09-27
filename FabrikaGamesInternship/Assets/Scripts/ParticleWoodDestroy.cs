using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleWoodDestroy : MonoBehaviour
{
    void Start()
    {
        Invoke("IsTriggerActiver", 0.1f);
        Destroy(this.gameObject, 3f);
    }
    void IsTriggerActiver()
    {
        this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
    }

}
