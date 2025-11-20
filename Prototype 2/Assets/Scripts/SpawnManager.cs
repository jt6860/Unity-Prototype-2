using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float startDelay = 2;
    public float spawnIntervalTop = 1.5f;
    public float spawnIntervalLeft = 3.0f;

    public float spawnRangeZTop = -14f;
    public float spawnRangeXTop = 18f;

    public float spawnLeftZMin = 16f;
    public float spawnLeftZMax = 24f;
    public float spawnLeftX = 25f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnRandomAnimalTop", startDelay, spawnIntervalTop);
        InvokeRepeating("spawnRandomAnimalLeft", startDelay, spawnIntervalLeft);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void spawnRandomAnimalTop()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeXTop, spawnRangeXTop), 0, spawnRangeZTop);

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void spawnRandomAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(spawnLeftX, 0, Random.Range(spawnLeftZMin, spawnLeftZMax));

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 270, 0));
    }
}
