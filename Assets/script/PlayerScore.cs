using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    int _openScore = 4;
    BlockScore[] _blockScore;
    private int _score = 0;
    public int Score => _score;
    public int _count = 0;
    public AudioClip _sound1;
    public AudioClip _sound2;
    public int _itemScoreText;
    public static int _itemScore;
    [SerializeField] public Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = _itemScore.ToString();
        Transform transform = GetComponent<Transform>();
        GameObject[] obj = GameObject.FindGameObjectsWithTag("box");
        _blockScore = new BlockScore[obj.Length];
        for (int i = 0; i < obj.Length; i++)
        {
            _blockScore[i] = obj[i].GetComponent<BlockScore>();
        }
        
    }

    // Update is called once per frame
    public void AddScore(int addScore)
    {
        _score += addScore;
        Debug.Log(_score);
    }

    public void ResetScore()
    {
        _score = 0;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rain")
        {
            transform.position = new Vector2(40f, 0f);
        }
        else if (collision.gameObject.tag == "warp")
        {
            transform.position = new Vector2(115f, 0f);
        }
        else if (collision.gameObject.tag == "wa2" || collision.gameObject.tag == "tri")
        {
            transform.position = new Vector2(115f, 0f);
        }
        else if (collision.gameObject.tag == "stick")
        {
            transform.position = new Vector2(193f, 0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "qube")
        {
            transform.position = new Vector2(280f, 0f);
        }
        if(collision.gameObject.tag == "MoveObject")
        {
            transform.position = new Vector2(280f, 0f);
        }
        if(collision.gameObject.tag == "Item")
        {
            _itemScore++;
            _text.text = _itemScore.ToString();
            Destroy(collision.gameObject);
        }
    }


}