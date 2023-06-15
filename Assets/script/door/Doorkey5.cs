using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorkey5 : MonoBehaviour
{
    PlayerScore _playerScore;
    int _key = 20;
    AudioSource _audioSource;
    public AudioClip _audioClip;
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
            ChangeScene();
            Debug.Log(20);
            _playerScore.ResetScore();
            _audioSource.PlayOneShot(_audioClip);
            ChangeScene();
        }
    }

    void ChangeScene()  
    {
        Debug.Log("Change");
        SceneManager.LoadScene("GameClear");
    }


}
