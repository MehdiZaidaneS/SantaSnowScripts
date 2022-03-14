using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> bolasPrefab;
    public int numero = 0;
    private GameManager gameManager;
    public int tiempo;

    void Start()
    {
        
        gameManager = FindObjectOfType<GameManager>();
        tiempo = gameManager.tiempo2;
        StartCoroutine(TiempoDeSpawn());
        
    }

    private void SpawnEnemy()
    {
        if (gameManager.vidas > 0 && gameManager.number > 4 && gameManager.start == 5)
        {
            int random = Random.Range(0, bolasPrefab.Count);
            Instantiate(bolasPrefab[random], transform.position, bolasPrefab[random].transform.rotation);
        }

    }
    
    IEnumerator TiempoDeSpawn()
    {
        while (numero < 1)
        {
            int segundos = Random.Range(1, tiempo);
            yield return new WaitForSeconds(segundos);
            SpawnEnemy();
        }
            
    }

    


}
