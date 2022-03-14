using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;
    public int jugadores= 0;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }

    void Update()
    {
        spawnPlayer();
    }


    public void spawnPlayer()
    {
        if (jugadores == 0 && gameManager.vidas > 0 && gameManager.number > 4 && gameManager.start == 5)
        {
            Instantiate(player, transform.position, player.transform.rotation);
            jugadores += 1;
        }

    }
    
   
}
