using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DetectCollisions : MonoBehaviour
{
    private SpawnPlayer spawnPlayer;
    private GameManager gameManager;
    void Start()
    {
        spawnPlayer = FindObjectOfType<SpawnPlayer>();
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            spawnPlayer.jugadores -= 1;
            gameManager.vidas -= 1;
            gameManager.bolasConseguidas = 0;
        }
    }

}
