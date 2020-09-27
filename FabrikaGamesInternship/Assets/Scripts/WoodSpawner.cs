using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpawner : MonoBehaviour
{
    public Rigidbody[] Woods;
    public GameObject[] SpawnPositions;
    private float SpawnSpeed = 7f;
    private int SpawnPositionNumber = 0;
    private int SpawnTypeNumber = 0;
    public static Rigidbody CloneWoods;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawningWoods());
    }  
    IEnumerator SpawningWoods()
    {
        while (true)
        {
            SpawnPositionNumber = Random.Range(0, 3);
            SpawnTypeNumber = Random.Range(0, 3);
            CloneWoods = Instantiate(Woods[SpawnTypeNumber], SpawnPositions[SpawnPositionNumber].transform.position, SpawnPositions[SpawnPositionNumber].transform.rotation);
            yield return new WaitForSeconds(SpawnSpeed);
            SpawnSpeed -= 0.1f;
            if(SpawnSpeed <= 0)
            {
                break;
            }
        }
    }
}
