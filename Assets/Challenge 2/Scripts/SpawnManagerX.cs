using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private readonly float spawnLimitXLeft = -22;
    private readonly float spawnLimitXRight = 7;
    private readonly float spawnPosY = 30;

    private readonly float startDelay = 2.0f;
    private float spawnInterval = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

        Invoke(nameof(SpawnRandomBall), startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        //Generate a random spawn position
        Vector3 spawnPos = new(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int randomIndex = Random.Range(0, ballPrefabs.Length);
        var ball = ballPrefabs.ElementAt(randomIndex);
        if (ball != null)
        {
            Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);   
        }
        else
        {
            Debug.Log("Ball is null!");
        }
        spawnInterval = Random.Range(3.0f, 6.0f);
        Debug.Log($"spawnInterval -> {spawnInterval}");
        Invoke(nameof(SpawnRandomBall), spawnInterval);
    }

}
