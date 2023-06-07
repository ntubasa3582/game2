using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockScore : MonoBehaviour
{
    [SerializeField]
    int _score1 = 1;
    bool _switch = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_switch)
        {
            if (collision.gameObject.tag == "Player")
            {
                PlayerScore playerScore = collision.gameObject.GetComponent<PlayerScore>();
                playerScore.AddScore(_score1);
                
                _switch = false;
                Debug.Log("“–‚½‚Á‚½");
            }
        }
    }
}
