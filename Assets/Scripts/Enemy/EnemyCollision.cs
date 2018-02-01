using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bullet") {
            Destroy(gameObject);
        }
        if(other.tag == "Player") {
            StartCoroutine(EnemyHit());
        }
        
    }

    IEnumerator EnemyHit() {
        yield return new WaitForEndOfFrame();
        Destroy(gameObject);
    }

    
}
