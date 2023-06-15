using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorkey2 : MonoBehaviour
{
    [SerializeField] GameObject _door2;
    PlayerScore _playerScore;
    AudioSource _audioSource;
    public AudioClip _audioclip;
    int _key = 8;

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
        if(_key <= _playerScore.Score)
        {
            Debug.Log("8");
            _playerScore.ResetScore();
            _audioSource.PlayOneShot(_audioclip);
            _door2.SetActive(false);
        }
    }
}
