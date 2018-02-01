using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    //reference to bullet prefab
    public GameObject bullet;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullet, new Vector3(transform.localPosition.x, transform.localPosition.y + 1f, 0), transform.rotation);
        }
    }
}
