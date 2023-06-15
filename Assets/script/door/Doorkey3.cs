using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorkey3 : MonoBehaviour
{

    [SerializeField] GameObject _door3;
    PlayerScore _playerScore;
    AudioSource _source;
    public AudioClip _audioclip;
    int _key = 12;
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
            //Debug.Log("12");
            _playerScore.ResetScore();
            _source.PlayOneShot(_audioclip);
            _door3.SetActive(false);
        }
    }
}
