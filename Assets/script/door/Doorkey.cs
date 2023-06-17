using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Doorkey : MonoBehaviour
{
    [SerializeField]
    GameObject[] _door1;
    int _count = 0;
    PlayerScore _playerScore;
    AudioSource _audioSource;
    public AudioClip _audioClip;
    int _key = 4;
    int _key2 = 8;
    //int _num = 2;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        _playerScore = obj.GetComponent<PlayerScore>();
        _audioSource = obj.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_key <= _playerScore.Score)
        {
            _door1[0].SetActive(false);
            _playerScore.ResetScore();
            _audioSource.PlayOneShot(_audioClip);
            //_count += 2;
            //  Debug.Log(_count);
        }
        //if(5 <= _playerScore.Score && 2 <= _count)
        //{
        //    //Debug.Log("‚ ‚¢‚¤");
        //}

    }
}
