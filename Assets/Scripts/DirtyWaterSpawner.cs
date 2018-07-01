using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyWaterSpawner : MonoBehaviour
{

    //--VARIABLES--//
    [SerializeField]
    public GameObject cleanWaterPrefab;
    public int dirtySpawnSeconds = 5;
    public GameObject gameManager;



    // Use this for initialization
    void Start()
    {
        StartCoroutine(TimeToStartDirtyWaterSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        gameDiffCheck();

    }

    IEnumerator TimeToStartDirtyWaterSpawn()
    {
        yield return new WaitForSeconds(30);
        StartCoroutine(SpawnDirtyWaterRoutine());
    }

    IEnumerator SpawnDirtyWaterRoutine()
    {
        while (true)
        {
            Instantiate(cleanWaterPrefab, new Vector2(Random.Range(-8.355783f, 8.355783f), 4.47f), Quaternion.identity);
            yield return new WaitForSeconds(dirtySpawnSeconds);
        }
    }

    void gameDiffCheck()
    {
        if (gameManager.GetComponent<GameManager>().gameDifficulty == 1)
        {
            dirtySpawnSeconds = 10;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 2)
        {
            dirtySpawnSeconds = 9;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 3)
        {
            dirtySpawnSeconds = 8;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 4)
        {
            dirtySpawnSeconds = 7;
        }

        if (gameManager.GetComponent<GameManager>().gameDifficulty == 5)
        {
            dirtySpawnSeconds = 6;
        }
    }
}

