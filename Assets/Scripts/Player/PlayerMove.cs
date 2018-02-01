using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float speed = 10f;
	public GameObject bullet;

	private float xPos;
	private float yPos;
	// Update is called once per frame
	void Update () {
		xPos = transform.position.x;
		yPos = transform.position.y;
		transform.Translate (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
		//mathf clamp
		if(Input.GetKeyDown(KeyCode.Space)){
			Instantiate (bullet, new Vector3 (transform.localPosition.x, transform.localPosition.y + 1f, 0), transform.rotation);
		}

		if (transform.position.x > -6) {
			//transform.position.x = -6;
		}
		else if(transform.position.x < 6){

		}		

		if(transform.position.y > -3){

		}
		else if(transform.position.y < 3){

		}
	}
}
