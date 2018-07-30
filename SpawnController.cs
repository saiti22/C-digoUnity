using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    [SerializeField] GameObject[] obstaclePattern;

    private float timeBtwSpawn;

    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update() {
        // Spawn/tempo de obstáculos
        if (timeBtwSpawn <= 0) {
            int rand = Random.Range(0, obstaclePattern.Length);
            Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime) {
                startTimeBtwSpawn -= decreaseTime;
            }
            
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }


}
