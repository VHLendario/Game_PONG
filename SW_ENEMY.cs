using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SW_ENEMY : MonoBehaviour
{
    public GameObject bolinha_2;
    SM_ENEMY scoremanager_enemy;
    // Start is called before the first frame update
    void Start()
    {
        scoremanager_enemy = GameObject.FindGameObjectWithTag("Score").GetComponent<SM_ENEMY>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            scoremanager_enemy.score_enemy += 1;
        }
    }

   
}
