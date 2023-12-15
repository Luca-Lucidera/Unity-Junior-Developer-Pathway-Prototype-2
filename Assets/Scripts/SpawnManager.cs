using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private readonly int rangeX = 10;
    private readonly int startTime = 2;
    private readonly float interval = 1.5f;

    public GameObject[] animalPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomMob), startTime, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnRandomMob()
    {
        var radomIndex = Random.Range(0, animalPrefabs.Length);
        var animal = animalPrefabs.ElementAt(radomIndex);
        if (animal != null)
        {
            var randomPositionSpawn = Random.Range(-rangeX, rangeX);
            var spawnPos = new Vector3(randomPositionSpawn, transform.position.y, transform.position.z);
            Instantiate(animal, spawnPos, animal.transform.rotation);
        }
    }
}
