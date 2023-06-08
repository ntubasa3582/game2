using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bwcolor : MonoBehaviour
{
    SpriteRenderer _obg = default;
    public GameObject obg;
    BoxCollider2D _boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        _obg = GetComponent<SpriteRenderer>();

        //_boxCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _obg.color = Color.white;
            //_boxCollider.enabled = true;
            _obg.sortingOrder = 0;
        }
        if(Input.GetMouseButtonDown(1)) 
        {
            _obg.color = Color.black;
            //_boxCollider.enabled = false;
            _obg.sortingOrder = -10;
        }

    }
}
