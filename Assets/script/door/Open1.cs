using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open1 : MonoBehaviour
{
    public bool _swich = false;
    public int _count = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_count > 0)
        {
            _swich = true;  
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _count++;
            _count++;
        }
    }
}
