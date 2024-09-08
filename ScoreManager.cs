using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Movimento player;
    MovimentoInimigo player2;
    MovimentoBola bola;
    public Text contador_de_pontos;
    public int score_;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimento>();
        player2 = GameObject.FindGameObjectWithTag("Enemy").GetComponent<MovimentoInimigo>();
    }

    // Update is called once per frame
    void Update()
    {
        contador_de_pontos.text = score_.ToString();
        Vencedor ();
    }

    void Vencedor ()
    {
        //vai analisar quando o score_chegar em 7, e define o vencedor.
        if (score_ == 7)
        {
            this.enabled = false;
        }
    }


}

