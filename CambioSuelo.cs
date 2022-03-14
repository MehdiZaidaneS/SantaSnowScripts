using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioSuelo : MonoBehaviour
{
    public Material piedra;
    public Material tierra;
    Renderer rend;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        rend = GetComponent<Renderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        cambioDeMapa();
    }
    

    void cambioDeMapa()
    {
        if(gameManager.level == 2 && gameManager.number > 4)
        {
            rend.sharedMaterial = piedra;
        } else if (gameManager.level == 3 && gameManager.number > 4)
        {
            rend.sharedMaterial = tierra;
        }
    }
}
