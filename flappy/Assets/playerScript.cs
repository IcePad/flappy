using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {
    // Use this for initialization
    public float speed = 2;
    public float maxSpeed;
    private Rigidbody2D rb2d;
	void Start () { 
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = 1;
        rb2d = GetComponent<Rigidbody2D>();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        if (moveHorizontal * rb2d.velocity.x < maxSpeed)
        {
            rb2d.AddForce(movement * speed);
        }else
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
    }

    void Update()
    {
     
        

        if (Input.GetKeyDown("space"))
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);

            GetComponent<Rigidbody2D>().AddForce(jump);
        }
    }
}
