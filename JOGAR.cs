using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JOGAR : MonoBehaviour
{
    public GameObject tela2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Iniciar ()
    {
        gameObject.SetActive(false);
        tela2.SetActive(true);
    }

    public void Iniciar02 ()
    {
        //SceneManager.LoadScene("SampleScene");
        //tela1.SetActive(true);
    }
}
