using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorkey4 : MonoBehaviour
{

    [SerializeField] GameObject _door4;
    PlayerScore _playerScore;
    int _key = 16;
    AudioSource _source;
    public AudioClip _clip;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        _playerScore = obj.GetComponent<PlayerScore>();
        _source = obj.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_key <= _playerScore.Score)
        {
            Debug.Log(16);
            _playerScore.ResetScore();
            _source.PlayOneShot(_clip);
            _door4.SetActive(false);
        }
    }
}
