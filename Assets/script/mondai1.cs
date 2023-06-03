using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mondai1 : MonoBehaviour
{
    int _count1 = 0;
    int _count2 = 0;
    int _count3 = 0;
    int _count4 = 0;
    int _touchcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_count1 == 1)
        {
            Debug.Log("1");
            if(_count2  == 1)
            {
                Debug.Log("1");
                if ( _count3 == 1)
                {
                    Debug.Log("1");
                    if (_count4 == 1)
                    {
                        Debug.Log("1");
                        _touchcount++;
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "box1")
        {
            _count1++;
        }
        if (collision.gameObject.tag == "box1")
        {
            _count2++;
        }
        if (collision.gameObject.tag == "box1")
        {
            _count3++;
        }
        if (collision.gameObject.tag == "box1")
        {
            _count4++;
        }

    }
}
