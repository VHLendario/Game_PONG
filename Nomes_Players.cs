using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nomes_Players : MonoBehaviour
{
    public GameObject tela1;
    public InputField nome_jogador_01;
    public InputField nome_jogador_02;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InciarPartida ()
    {
        SalvarNome ();
        SceneManager.LoadScene("SampleScene");
    }

    public void Voltar ()
    {
        gameObject.SetActive(false);
        tela1.SetActive(true);
    }

    void SalvarNome ()
    {
        string nome_01 = nome_jogador_01.text;
        PlayerPrefs.SetString("PlayerName01", nome_01);
        PlayerPrefs.Save();
        string nome_02 = nome_jogador_02.text;
        PlayerPrefs.SetString("PlayerName02", nome_02);
        PlayerPrefs.Save();
    }
}
