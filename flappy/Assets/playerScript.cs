using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		//GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);

		{
			if (Input.GetKeyDown ("space")) {
				Vector3 jump = new Vector3 (0.0f, 200.0f, 0.0f);

				GetComponent<Rigidbody2D>().AddForce (jump);
			}
		}
	}
}
