using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] int startingWave = 0;  // Serialized for debugging
    [SerializeField] bool looping = false;

	// Use this for initialization
	IEnumerator Start () {
        do
        {
            yield return StartCoroutine(SpawnAllWaves());

        }
        while (looping);
    }

    private IEnumerator SpawnAllWaves()
    {
        for (int waveCount = startingWave; waveCount < waveConfigs.Count; waveCount++)
        {
            new WaitForSeconds(3);
            yield return StartCoroutine(SpawnAllWaveEnemies(waveConfigs[waveCount]));
        }
    }
	
	private IEnumerator SpawnAllWaveEnemies(WaveConfig waveConfig)
    {
        for (int enemyCount = 0; enemyCount < waveConfig.getNumberOfEnemies(); enemyCount++)
        {
            var newEnemy = Instantiate(
                waveConfig.getEnemyPrefab(),
                waveConfig.getWaypoints()[0].transform.position,
                Quaternion.identity);

            newEnemy.GetComponent<EnemyPathing>().SetWaveConfig(waveConfig);

            yield return new WaitForSeconds(waveConfig.getTimeBetweenSpans());
        }
    }
}
