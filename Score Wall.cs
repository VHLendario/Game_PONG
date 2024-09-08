using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWall : MonoBehaviour
{
    ScoreManager scoremanager_;
    public GameObject bolinha_;
    // Start is called before the first frame update
    void Start()
    {
       scoremanager_ = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            scoremanager_.score_ += 1;
            
        }
    }

    
}
