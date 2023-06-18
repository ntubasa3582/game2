using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerText : MonoBehaviour
{
    BlockScore blockScore;
    [SerializeField] Text _text1;
    [SerializeField] Text _text2;
    [SerializeField] Text _text3;
    [SerializeField] Text _text4;
    public int _textcount;
    public int _blockcount;
    public AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        blockScore = GetComponent<BlockScore>();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_blockcount >= 4)
        {
            _blockcount = 0;
            _text4.text = _blockcount.ToString("0");
            _audioSource.enabled = true;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Stagecensor")
        {
            _textcount++;
            _text2.text = _textcount.ToString("0");
        }
        else if(collision.gameObject.tag == "box")
        {
            _audioSource.enabled=false;
            _blockcount++;
            _text4.text = _blockcount.ToString("0");
        }
    }
}
