using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    private SpawnPlayer spawnPlayer;
    public TextMeshProUGUI numero;
    public TextMeshProUGUI bolas;
    public TextMeshProUGUI nivel;
    public GameObject foto1;
    public GameObject foto2;
    public GameObject foto3;
    public GameObject foto4;
    public GameObject foto5;
    public int number;
    public int bolasConseguidas = 0;
    public int level;
    public int bolasQueDebeConseguir;
    public int vidas;
    public float velocity = 100;
    public int tiempo2 = 5;
    public float tiempoDeVida = 3;
    public int start;


    void Start()
    {
        
        start = 0;
        vidas = 5;
        number = 1;
        level = 1;
        bolasQueDebeConseguir = 20;
        bolas.text = "-Dodged balls: " + bolasConseguidas + "/" + bolasQueDebeConseguir;
        StartCoroutine(NumeroMetodo());
    }

    void Update()
    {
        cambioDeVida();
        spawnPlayer = FindObjectOfType<SpawnPlayer>();
        player = GameObject.FindGameObjectWithTag("Player");
        bolas.text = "-Dodged balls: " + bolasConseguidas + "/" + bolasQueDebeConseguir;
        nivel.text = "-Level: " + level;
        siguienteLevel();
        ultimoLevel();
        GameOver();
        winTexto();
        
    }

    public void Numero()
    {

        if (number < 4)
        {
            numero.text = "" + number;
            number += 1;
            numero.gameObject.SetActive(true);
            bolas.gameObject.SetActive(false);
            nivel.gameObject.SetActive(false);
            foto1.gameObject.SetActive(false);
            foto2.gameObject.SetActive(false);
            foto3.gameObject.SetActive(false);
            foto4.gameObject.SetActive(false);
            foto5.gameObject.SetActive(false);




        } else
        {

            numero.gameObject.SetActive(false);
            StartCoroutine(levelTiempo());
            StartCoroutine(Arranca());
            number += 1;
        }

    }
    IEnumerator NumeroMetodo()
    {
        while (number < 7)
        {
            Numero();
            bolasConseguidas = 0;
            yield return new WaitForSeconds(1);
        }

    }


    void siguienteLevel()
    {
        if (level == 1 && bolasConseguidas >= 20)
        {
            start = 0;
            tiempoDeVida = 2;
            tiempo2 = 3;
            velocity *= 2;
            bolasQueDebeConseguir = 50;
            level += 1;
            Destroy(player);
            spawnPlayer.jugadores -= 1;
            number = 1;
            StartCoroutine(NumeroMetodo());
        }
    }

    void ultimoLevel()
    {
        if (level == 2 && bolasConseguidas >= 50) {

            start = 0;
            tiempoDeVida = 2;
            tiempo2 = 1;
            velocity *= 3;
            level += 1;
            bolasQueDebeConseguir = 50;
            Destroy(player);
            spawnPlayer.jugadores -= 1;
            number = 1;
            StartCoroutine(NumeroMetodo());
        }

    }


    void winTexto()
    {
        if (level == 3 && bolasConseguidas >= 50)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
    void GameOver()
    {
        if (vidas == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void cambioDeVida()
    {
        if(vidas == 4)
        {
            foto5.gameObject.SetActive(false);
        } else if (vidas == 3)
        {
            foto4.gameObject.SetActive(false);
        } else if (vidas == 2)
        {
            foto3.gameObject.SetActive(false);
        } else if (vidas == 1)
        {
            foto2.gameObject.SetActive(false);
        }
    }


    IEnumerator levelTiempo()
    {
        nivel.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        nivel.gameObject.SetActive(false);
        
    }
    IEnumerator Arranca()
    {
        yield return new WaitForSeconds(3);
        start = 5;
        bolas.gameObject.SetActive(true);
        if (vidas == 5)
        {
            foto1.gameObject.SetActive(true);
            foto2.gameObject.SetActive(true);
            foto3.gameObject.SetActive(true);
            foto4.gameObject.SetActive(true);
            foto5.gameObject.SetActive(true);
        }
        else if (vidas == 4)
        {
            foto1.gameObject.SetActive(true);
            foto2.gameObject.SetActive(true);
            foto3.gameObject.SetActive(true);
            foto4.gameObject.SetActive(true);
        }
        else if (vidas == 3)
        {
            foto1.gameObject.SetActive(true);
            foto2.gameObject.SetActive(true);
            foto3.gameObject.SetActive(true);
        }
        else if (vidas == 2)
        {
            foto1.gameObject.SetActive(true);
            foto2.gameObject.SetActive(true);
        }
        else if (vidas == 1)
        {
            foto1.gameObject.SetActive(true);
        }
    }
}
