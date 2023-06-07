using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class PlayerScore : MonoBehaviour
{
    int _openScore = 4;
    BlockScore[] _blockScore;
    private int _score = 0;
    public int Score => _score;
    public int _count = 0;



    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
        GameObject[] obj = GameObject.FindGameObjectsWithTag("box");
        _blockScore = new BlockScore[obj.Length];
        for (int i = 0; i < obj.Length; i++)
        {
            _blockScore[i] = obj[i].GetComponent<BlockScore>(); 
        }

    }

    // Update is called once per frame
    public void Update()
    {
    }

    public void AddScore(int addScore)
    {
        _score += addScore;
    }

    public void ResetScore() 
    {
        _score = 0;
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "rain")
        {
            transform.position = new Vector2(40f, 6f);
        }
    }
}