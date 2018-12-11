                  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	// enemy you would like to spawn
	public Transform enemyPrefab;

    // Boss enemy prefab to spawn in
    public Transform bossPrefab;

    // Sets enemy spawn point
    public Transform spawnPoint;

	// Time in between the waves
	public float timeBetweenWaves = 10f;

    // Time before the first wave
    public bool startCount = false;
	private float countdown = 5f;

	// Reference to the countdown text
	// public Text WaveCountdownText;

	private int waveIndex = 14;

	void Update(){
		// if countdown hits 0 then start the wave
		if(countdown <= 0){
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}
            countdown -= Time.deltaTime;
		// WaveCountdownText.text = Mathf.Round(countdown).ToString();
	}

    //IEnumerator allows to pause it before spawning a new wave
    IEnumerator SpawnWave()
    {
        waveIndex++;
        Debug.Log("Wave Incomming! Wave: " + waveIndex);

        // Check if waveIndex is 15 if so spawn boss wave 
        if (waveIndex == 15)
        {
            Debug.Log("Boss Wave!!" + waveIndex);
            SpawnBoss();
            yield return new WaitForSeconds(1f);
        }

        for (int i = 0; i < waveIndex; i++)
        {
            if (waveIndex < 15)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1.5f);
            }

            else if (waveIndex > 15 && waveIndex < 30)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(3f);
            }

            else if (waveIndex > 30 && waveIndex < 45)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(4.5f);
            }

        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnBoss()
    {
        Instantiate(bossPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
