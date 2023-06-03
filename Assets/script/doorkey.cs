using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class doorkey : MonoBehaviour
{
    [SerializeField]
    GameObject[] _door1;

    PlayerScore _playerScore;
    int _key = 4;

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
            _door1[0].SetActive(false);
            _playerScore.ResetScore();
        }
    }
}
