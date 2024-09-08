using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Transform ball;
    public float move_speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAD ();
    }

    //Movimento para PLayer 1
    void MoveAD ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * -move_speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * move_speed);
        }
    }

    //Movimento para IA
    void MovePR ()
    {
        
        float newX = Mathf.MoveTowards(transform.position.x, ball.position.x, move_speed * Time.deltaTime);
        Vector2 newPosition = new Vector2(newX, transform.position.y);
        rb.MovePosition(newPosition); 
    }

}
