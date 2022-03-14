using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    private GameManager gameManager;
    public float speed;
    private float muerte;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        muerte = gameManager.tiempoDeVida;
        speed = gameManager.velocity;
    }

    void Update()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
        StartCoroutine(TiempoDeVida());
    }

    IEnumerator TiempoDeVida()
    {
          yield return new WaitForSeconds(muerte);
          Destroy(gameObject);
          gameManager.bolasConseguidas += 1;
    }

    

    }

