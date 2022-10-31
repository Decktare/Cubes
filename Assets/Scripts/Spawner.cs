using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject cubePrefab;    
    [SerializeField]private float spawnTimer;

    private float spawnTimerStart = 0;

    public float spawnTimerEnd;

    private void Update()
    {
        SpawnTimer();
    }

    private void SpawnTimer()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTimerEnd) SpawnTimerReset();
    }

    private void SpawnTimerReset()
    {
        spawnTimer = spawnTimerStart;
        SpawnCube();
    }

    private void SpawnCube()
    {
        GameObject cube = (GameObject)Instantiate(cubePrefab);
        //cube.GetComponent<Cube>().speed = 100f;
    }
}
