using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainColor : MonoBehaviour
{
    SpriteRenderer _renderer;
    //int _count;
    GeneratorB _generatorB;
    //SpriteRenderer _spriteRenderer;
    public void Start()
    {
        _generatorB = FindObjectOfType<GeneratorB>();
        //_spriteRenderer = GetComponent<SpriteRenderer>();
        //_spriteRenderer.color = Color.white;
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.color = _generatorB.ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        //if(_generatorB._count >= 1)
        //{
        //    _spriteRenderer.color = Color.black;
        //}
        //if(Input.GetMouseButtonDown(0))
        //{
        //    _renderer.color = Color.white;
        //}
        //if(Input.GetMouseButtonDown(1))
        //{
        //    _renderer.color = Color.black;
        //}
        _renderer.color =  _generatorB.ChangeColor();
    }
}
