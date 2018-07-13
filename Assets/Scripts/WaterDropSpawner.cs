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
    public bool isworking = false;
    public int limiter = 0;



    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameDiffCheck();
        if(gameManager.GetComponent<GameManager>().gameHasStarted == true && limiter == 0 )
        {
            StartCoroutine(SpawnCleanWaterRoutine());
            limiter = 1;
        }
    }

    IEnumerator SpawnCleanWaterRoutine()
    {
        while(true)
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
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 3)
        {
            cleanSpawnSeconds = 3;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 4)
        {
            cleanSpawnSeconds = 2;

            if (gameManager.GetComponent<GameManager>().gameDifficulty == 5)
            {
                cleanSpawnSeconds = 1;
            }
        }
    }
}
