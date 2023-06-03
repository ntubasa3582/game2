using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int _openScore = 4;
    BlockScore[] _blockScore;
    private int _score = 0;
    public int Score => _score;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("box");
        _blockScore = new BlockScore[obj.Length];
        for (int i = 0; i < obj.Length; i++)
        {
            _blockScore[i] = obj[i].GetComponent<BlockScore>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if (_blockScore[0]._score1 == _OpenScore)
        //{
        //    Debug.Log("ÉIÅ[ÉvÉì");
        //    _isOpen++;
        //}
    }

    public void AddScore(int addScore)
    {
        _score += addScore;
    }

    public void ResetScore() 
    {
        _score = 0;
    }
}
