using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bwcolor2 : MonoBehaviour
{
    SpriteRenderer _obg = default;
    public GameObject obg;
    // Start is called before the first frame update
    void Start()
    {
        _obg = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _obg.color = Color.white;
        }
        if (Input.GetMouseButtonDown(0))
        {
            _obg.color = Color.black;
        }
    }
}
