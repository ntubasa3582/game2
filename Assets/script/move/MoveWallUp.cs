using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWallUp : MonoBehaviour
{
    void FixedUpdate()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbody���擾
        Vector2 force = new Vector3(0.0f, 2.0f);    // �͂�ݒ�
        rb.AddForce(force);  // �͂�������
    }
}