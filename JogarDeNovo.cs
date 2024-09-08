using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogarDeNovo : MonoBehaviour
{
    public Text vencedor_player;

    ScoreManager P1;
    SM_ENEMY P2;

    // Start is called before the first frame update
    void Start()
    {
        P1 = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        P2 = GameObject.FindGameObjectWithTag("Score").GetComponent<SM_ENEMY>();
    }

    // Update is called once per frame
    void Update()
    {
       FinalVencedor ();
    }

    public void PlayAgain ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Menu ()
    {
        SceneManager.LoadScene ("InitialScene");
    }

    void FinalVencedor ()
    {
        string nome_01 = PlayerPrefs.GetString("PlayerName01", "Nome");
        string nome_02 = PlayerPrefs.GetString("PlayerName02", "Nome");
        if (P1.score_ == 7)
        {
            vencedor_player.text = nome_01 + " ganhou!";
        }
        if (P2.score_enemy == 7)
        {
            vencedor_player.text = nome_02 + " ganhou!";
        }
    }

    void teste_nome ()
    {
        string nome_01 = PlayerPrefs.GetString("PlayerName01", "Nada Salvo");
        Debug.Log("Nome Salvo: " + nome_01);
    }
}
