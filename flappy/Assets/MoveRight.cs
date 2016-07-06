using UnityEngine;
using System.Collections;

public class MoveRight : MonoBehaviour
{
    // Use this for initialization
    public float speed = 2;
    public float maxSpeed;
    private Rigidbody2D rb2d2;
    void Start()
    {
        rb2d2= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = 1;
        rb2d2 = GetComponent<Rigidbody2D>();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        if (moveHorizontal * rb2d2.velocity.x < 5)
        {
            rb2d2.AddForce(movement * 5);
        }
        else
        {
            rb2d2.velocity = new Vector2(5, rb2d2.velocity.y);
        }
    }

  
}
