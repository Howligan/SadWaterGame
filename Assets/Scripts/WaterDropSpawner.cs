using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropSpawner : MonoBehaviour {

    //--VARIABLES--//
    [SerializeField]
    public GameObject cleanWaterPrefab;
    public GameObject dirtyWaterPrefab;
    public int spawnSeconds;


    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnWaterRoutine());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnWaterRoutine()
    {
        while (true)
        {
            Instantiate(cleanWaterPrefab, new Vector2(Random.Range(-8.355783f, 8.355783f),4.47f), Quaternion.identity);
            yield return new WaitForSeconds(spawnSeconds);
        }
    }
}
