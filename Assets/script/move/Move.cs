using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        _rb.velocity = new Vector2(x, y) * _moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wa2" || collision.gameObject.tag =="tri")
        {
            transform.position = new Vector2(115f, 0f);
        }
        else if(collision.gameObject.tag == "stick")
        {
            transform.position = new Vector2(193f, 0f);
        }
    }
}
