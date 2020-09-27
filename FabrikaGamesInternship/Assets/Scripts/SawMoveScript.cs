using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMoveScript : MonoBehaviour
{
    public GameObject CutterSaw;
    private float speed = 10f;
    public void LeftButtonDown()
    {
        StartCoroutine(LeftMoveSaw(-1f));
    }
    public void LeftButtonUp()
    {
        StopAllCoroutines();
    }
    public void RightButtonDown()
    {
        StartCoroutine(RightMoveSaw(1f));
    }
    public void RightButtonUp()
    {
        StopAllCoroutines();
    }
    IEnumerator LeftMoveSaw(float HorizontalInput)
    {
        while (true)
        {
            if (CutterSaw.transform.position.x > -10)
            {
                CutterSaw.transform.position += new Vector3(HorizontalInput * speed * Time.deltaTime, 0, 0);
            }
            yield return new WaitForSeconds(0.01f);
        }
        
    }
    IEnumerator RightMoveSaw(float HorizontalInput)
    {
        while (true)
        {
            if (CutterSaw.transform.position.x < 10)
            {
                CutterSaw.transform.position += new Vector3(HorizontalInput * speed * Time.deltaTime, 0, 0);
            }
            yield return new WaitForSeconds(0.01f);
        }

    }
}
