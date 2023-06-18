using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Rigidbody2D _rb;
    public AudioClip _audioClip;
    //AudioSource _audioSource;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        _rb.velocity = new Vector2(x, y) * _moveSpeed;
        if(Input.GetMouseButtonDown(0)) 
        {
            //_audioSource.PlayOneShot(_audioClip);
        }
        if(Input.GetMouseButtonDown(1))
        {

           // _audioSource.PlayOneShot(_audioClip);
        }


    }
}
