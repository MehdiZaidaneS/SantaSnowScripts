using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuera : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if(transform.position.x > 190)
        {
            Destroy(gameObject);
            gameManager.bolasConseguidas += 1;
        } 
        if (transform.position.x < -230)
        {
            Destroy(gameObject);
            gameManager.bolasConseguidas += 1;
        } 
        if (transform.position.z > 130)
        {
            Destroy(gameObject);
            gameManager.bolasConseguidas += 1;
        }
        if (transform.position.z < -140)
        {
            Destroy(gameObject);
            gameManager.bolasConseguidas += 1;
        }
    }
}
