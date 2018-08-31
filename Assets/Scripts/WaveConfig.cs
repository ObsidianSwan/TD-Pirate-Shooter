using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject {

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpans = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject getEnemyPrefab() { return enemyPrefab; }

    public List<Transform> getWaypoints()
    {
        var waveWaypoints = new List<Transform>();
        foreach (Transform waypoint in pathPrefab.transform)
        {
            waveWaypoints.Add(waypoint);
        }
        return waveWaypoints;
    }

    public float getTimeBetweenSpans() { return timeBetweenSpans; }

    public float getSpawnRandomFactor() { return spawnRandomFactor; }

    public int getNumberOfEnemies() { return numberOfEnemies; }

    public float getMoveSpeed() { return moveSpeed; }
}
