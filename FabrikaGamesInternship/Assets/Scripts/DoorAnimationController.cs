using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationController : MonoBehaviour
{
    public GameObject LeftDoor;
    public GameObject RightDoor;
    // Update is called once per frame

    private void Start()
    {
        StartCoroutine(DoorOpener());
    }
    IEnumerator DoorOpener()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            LeftDoor.GetComponent<Animator>().Play("LeftDoorAnimation");
            RightDoor.GetComponent<Animator>().Play("RightDoorAnimation");
            
        }
    }
}
