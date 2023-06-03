using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int _OpenScore = 4;
    BlockScore _blockScore;
    bool _isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        _blockScore = obj.GetComponent<BlockScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_OpenScore <= _blockScore._score1) 
        {
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
