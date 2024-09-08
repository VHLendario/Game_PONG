using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SM_ENEMY : MonoBehaviour
{
    public Text contador_de_pontos_inimigo;
    public int score_enemy;
    Movimento move_player1;
    MovimentoInimigo move_player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador_de_pontos_inimigo.text = score_enemy.ToString();
        Vencedor ();
    }

    void Vencedor ()
    {
        if (score_enemy == 7)
        {
            this.enabled = false;
        }
    }
}
