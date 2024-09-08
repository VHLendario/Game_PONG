using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimentoInimigo : MonoBehaviour
{
    //GameObject ball_object;
    public Transform ball;
    
    public float move_speed_enemy;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //ball = GameObject.FindGameObjectWithTag("Ball");
       
        rb = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       MoveNM();
    }

    //movimento IA
    void MovePT ()
    {
        
        float newX = Mathf.MoveTowards(transform.position.x, ball.position.x, move_speed_enemy * Time.deltaTime);
        Vector2 newPosition = new Vector2(newX, transform.position.y);
        rb.MovePosition(newPosition); 
    }


    //Função para caso queira jogar de 2 PLAYERS
    void MoveNM ()
    {
        if (Input.GetKey(KeyCode.N))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * -move_speed_enemy);
        }

        if (Input.GetKey(KeyCode.M))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * move_speed_enemy);
        }
    }
}
