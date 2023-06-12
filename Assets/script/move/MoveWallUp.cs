using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWallUp : MonoBehaviour
{
    void FixedUpdate()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbody‚ğæ“¾
        Vector2 force = new Vector3(0.0f, 2.0f);    // —Í‚ğİ’è
        rb.AddForce(force);  // —Í‚ğ‰Á‚¦‚é
    }
}