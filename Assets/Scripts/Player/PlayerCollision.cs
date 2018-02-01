using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public bool canBeHit = true;

    private void Update() {
        gameObject.GetComponent<BoxCollider2D>().enabled = canBeHit;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (canBeHit == true) {
            if (other.tag == "Enemy") {
                canBeHit = false;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
                StartCoroutine(Respawn());
            }
        }
    }

    IEnumerator Respawn() {
        yield return new WaitForSeconds(1f);
        for(int i = 0; i < 3; i++) {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(0.2f);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(0.2f);
        }
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        canBeHit = true;
        yield return null;
    }
}
