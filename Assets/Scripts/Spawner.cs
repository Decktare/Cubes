using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private UI UIComponent;
    
    private float spawnTimer;    
    private float spawnTimerEnd = 0;   

    public float spawnTimerStart;

    private void Start()
    {
        spawnTimer = spawnTimerStart;
    }
    private void Update()
    {
        SpawnTimer();
    }

    private void SpawnTimer()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= spawnTimerEnd) SpawnTimerReset();
    }

    private void SpawnTimerReset()
    {
        spawnTimerStart = Parse(UIComponent.time, spawnTimerStart);
        
        spawnTimer = spawnTimerStart;
        SpawnCube();
    }

    private void SpawnCube()
    {
        GameObject cube = (GameObject)Instantiate(cubePrefab);

        cube.GetComponent<Cube>().speed = Parse(UIComponent.speed, cube.GetComponent<Cube>().speed);
        cube.GetComponent<Cube>().deadRange = Parse(UIComponent.range, cube.GetComponent<Cube>().deadRange);
    }

    private float Parse(string inputValue, float parameterParseTo)
    {
        float defaultParameter = parameterParseTo;

        if (float.TryParse(inputValue, out parameterParseTo))
        {
            return parameterParseTo;
        }
        else
        {
            return defaultParameter;
        }
    }
}
