using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockScore : MonoBehaviour
{
    bool _box;
    public int _score1 = 1;
    bool _switch = true;
    int _switch2 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(_switch2 == 1)
        {
            _switch = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(_switch == true)
        {
            if (collision.gameObject.tag == "Player")
            {
                _score1++;
                Debug.Log("“–‚½‚Á‚½");
                _switch2++;
            }
        }
    }
}
