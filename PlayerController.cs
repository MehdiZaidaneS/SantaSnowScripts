using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private float speed = 100;
    void Update()
    {
        transform.Translate((Input.GetAxis("Horizontal") * speed * Time.deltaTime), 0, (Input.GetAxis("Vertical") * speed * Time.deltaTime));

        if (transform.position.z > 108)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 108);
        }
        if (transform.position.z < -105)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -105);
        }
        if (transform.position.x < -180)
        {
            transform.position = new Vector3(-180, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 185)
        {
            transform.position = new Vector3(185, transform.position.y, transform.position.z);
        }

    }

}
