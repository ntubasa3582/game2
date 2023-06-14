using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorkey5 : MonoBehaviour
{
    PlayerScore _playerScore;
    int _key = 20;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        _playerScore = obj.GetComponent<PlayerScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_key <= _playerScore.Score)
        {
            ChangeScene();
            Debug.Log(20);
            _playerScore.ResetScore();
            ChangeScene();
        }
    }

    void ChangeScene()  
    {
        Debug.Log("Change");
        SceneManager.LoadScene("GameClear");
    }


}
