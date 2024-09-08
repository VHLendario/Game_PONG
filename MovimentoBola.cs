using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBola : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D _rigidbody;
    private Vector3 posição_inicial;

    //para aumentar a velocidade
    public float speedIncreaseRate = 0.1f;
    private Vector2 velocity;


    //para controlar a velocidade
    float x;
    float y;

    //para encerrar a bola do jogo
    ScoreManager pontuação_encerrada;
    SM_ENEMY pontuação_encerrada2;
    public GameObject game_over;


    // Start is called before the first frame update
    void Start()
    {
        posição_inicial = transform.position;
        _rigidbody = GetComponent <Rigidbody2D>();  
        PositionBall ();

        //para aumentar a velocidade
        velocity = new Vector2(speed, speed);
        _rigidbody.velocity = velocity;

        //para trabalhar com o score do p1 e p2
        pontuação_encerrada = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        pontuação_encerrada2 = GameObject.FindGameObjectWithTag("Score").GetComponent<SM_ENEMY>();
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseSpeedOverTime ();
        Encerrando ();
    }

    
    private void PositionBall()
    {
        float x = Random.Range(0, 2) == 0 ? 1 : 1; // Seta o X para 1 ou -1 aleatoriamente
        float y = Random.Range(0, 2) == 0 ? 1 : 1; // Seta o Y para 1 ou -1 aleatoriamente
        _rigidbody.velocity = new Vector2(x, y) * speed; // Multiplica a direção inicial pela velocidade e seta como a velocity
    }

    

    //se ela colidir com um objeto é resetada por meio da função resetball
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            ResetBall ();
        }
        
    }

    //para resetar a bola, vai rodar no ontrigger
    public void ResetBall ()
    {
        transform.position = posição_inicial;
        PositionBall ();
    }
    
    private void IncreaseSpeedOverTime()
    {
        // Aumenta a velocidade da bolinha
        _rigidbody.velocity = _rigidbody.velocity.normalized * (_rigidbody.velocity.magnitude + speedIncreaseRate * Time.deltaTime);
    }

    void Encerrando ()
    {
        if (pontuação_encerrada.score_ == 7 || pontuação_encerrada2.score_enemy == 7)
        {
            gameObject.SetActive(false);
            game_over.SetActive(true);
        }
    }

}
