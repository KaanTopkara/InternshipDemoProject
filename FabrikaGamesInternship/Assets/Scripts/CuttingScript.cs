using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class CuttingScript : MonoBehaviour
{
    
    public Rigidbody[] WoodPart_1;
    public Rigidbody[] WoodPart_2;
    public GameObject[] LeftWoodCuttedPositions;
    public GameObject[] RightWoodCuttedPositions;
    public Rigidbody WoodParticle;
    public GameObject WoodParticleSpawnPosition;
    private static int WoodType = 0;
    private int WoodCreateCheckNumber = 3;
    private float Accelerator = 250f;
    private static int Score = 0;
    public GameObject Camera;
    public GameObject GameOverMenu;
    public Text ScoreText;
    public Text GameOverScoreText;
    private bool CollisionShifter = true;
    private void Update()
    {
        ScoreText.text = Score.ToString();
        GameOverScoreText.text = Score.ToString();
        WoodType = TypeDetectionScript.WoodType;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ConnectionPoint" && CollisionShifter)
        {
            CollisionShifter = false;
            StartCoroutine(WoodParticleCreator());
            StartCoroutine(CameraTilt());
            Time.timeScale = 0.6f;
            Debug.Log(WoodType);
            Invoke("WoodCut", 0.1f);
           
        }
        else if (collision.gameObject.tag == "Type_1" || collision.gameObject.tag == "Type_2" || collision.gameObject.tag == "Type_3" && CollisionShifter)
        {
            CollisionShifter = false;
            Time.timeScale = 0f;
            GameOverMenu.SetActive(true);          
        }
    }
    void WoodCut()
    {
        if (WoodCreateCheckNumber >= 3)
        {
            Instantiate(WoodPart_1[WoodType], LeftWoodCuttedPositions[WoodType].transform.position, WoodPart_1[WoodType].transform.rotation);
            WoodPart_1[WoodType].velocity = new Vector3(0, -1, 0) * Accelerator;
            Instantiate(WoodPart_2[WoodType], RightWoodCuttedPositions[WoodType].transform.position, WoodPart_1[WoodType].transform.rotation);
            WoodPart_2[WoodType].velocity = new Vector3(0, -1, 0) * Accelerator;
            WoodCreateCheckNumber = 0;
            Score += 10;
        }
    }
    IEnumerator WoodParticleCreator()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                Rigidbody Particles;
                Particles = Instantiate(WoodParticle, WoodParticleSpawnPosition.transform.position, Quaternion.identity);
                Particles.velocity = new Vector3(0, 1, 1) * 20;
            }
            yield return new WaitForSeconds(0.1f);
            WoodCreateCheckNumber += 1;
        }
        CollisionShifter = true;
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
    }
    IEnumerator CameraTilt()
    {
        for (int i = 0; i < 7; i++)
        {
            Camera.transform.position = Camera.transform.position + new Vector3(1, 1, 0) * 0.2f;
            yield return new WaitForSeconds(0.05f);
            Camera.transform.position = Camera.transform.position - new Vector3(1, 1, 0) * 0.2f;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
