using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bwcolor : MonoBehaviour
{
    SpriteRenderer _obg = default;
    BoxCollider2D _boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        _obg = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
        _obg.sortingOrder = -1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _obg.color = Color.black;
            _obg.sortingOrder = -10;
            _boxCollider.enabled = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            _obg.color = Color.white;
            _obg.sortingOrder = 0;
            _boxCollider.enabled = true;
        }

    }
}
