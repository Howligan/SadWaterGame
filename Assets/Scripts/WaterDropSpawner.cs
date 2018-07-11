using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropSpawner : MonoBehaviour
{

    //--VARIABLES--//
    [SerializeField]
    public GameObject cleanWaterPrefab;
    public int cleanSpawnSeconds;
    public GameObject gameManager;



    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnCleanWaterRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        gameDiffCheck();
    }

    IEnumerator SpawnCleanWaterRoutine()
    {
        while (true)
        {
            Instantiate(cleanWaterPrefab, new Vector2(Random.Range(-3.9f, 3.9f), 8.67f), Quaternion.identity);
            yield return new WaitForSeconds(cleanSpawnSeconds);
        }
    }

    void gameDiffCheck()
    {
        if (gameManager.GetComponent<GameManager>().gameDifficulty == 1)
        {
            cleanSpawnSeconds = 5;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 2)
        {
            cleanSpawnSeconds = 4;
            // dirtySpawnSeconds = 10;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 3)
        {
            cleanSpawnSeconds = 3;
            //dirtySpawnSeconds = 9;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 4)
        {
            cleanSpawnSeconds = 2;
            //dirtySpawnSeconds = 8;        }

            if (gameManager.GetComponent<GameManager>().gameDifficulty == 5)
            {
                cleanSpawnSeconds = 1;
                //dirtySpawnSeconds = 6;
            }
        }
    }
    /*
         public GameObject dirtyWaterPrefab;
         public int dirtySpawnSeconds;
         StartCoroutine(TimeToStartDirtyWaterSpawn());
             IEnumerator SpawnDirtyWaterRoutine()
    {
        while (gameManager.GetComponent<GameManager>().gameDifficulty >= 2)
        {
            Instantiate(dirtyWaterPrefab, new Vector2(Random.Range(-8.355783f, 8.355783f), 4.47f), Quaternion.identity);
            yield return new WaitForSeconds(dirtySpawnSeconds);
        }
    }

        IEnumerator TimeToStartDirtyWaterSpawn()
    {
        yield return new WaitForSeconds(30);
        StartCoroutine(SpawnDirtyWaterRoutine());
    }


     */
}
