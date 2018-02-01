using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    //reference to bullet prefab
    public GameObject bullet;
	bool canShoot;
    // Update is called once per frame
    void Update () {
		canShoot = gameObject.GetComponentInChildren<Collider2D> ().isActiveAndEnabled;
        if (Input.GetKeyDown(KeyCode.Space)) {
			if (canShoot == true) {
				Instantiate (bullet, new Vector3 (transform.localPosition.x, transform.localPosition.y + 1f, 0), transform.rotation);
			}
        }
    }
}
