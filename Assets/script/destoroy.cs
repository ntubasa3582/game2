using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rain")
        {
        }
        else
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {

        }
    }
}
