using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    //speed of the ship
    public float speed = 10f;



	// Update is called once per frame
	void Update () {
		
        //moves the ship
		transform.Translate (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 
                             Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        //keeps the ship in bounds
        transform.position = new Vector3(
                            Mathf.Clamp(transform.position.x, -6, 6),
                            Mathf.Clamp(transform.position.y, -3, 3),
                            0);

        //shoots the bullet
		
	}
}
