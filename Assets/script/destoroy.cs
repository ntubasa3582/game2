using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoroy : MonoBehaviour
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
