using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemy;
    public bool spawnEnemies = true;

    private void Start() {
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy() {
        while (spawnEnemies == true) {
            yield return new WaitForSeconds(Random.Range(1, 3));
            Instantiate(enemy, new Vector3(Random.Range(-4, 4), transform.position.y, 0), 
                               transform.rotation);
        }
    }
}
