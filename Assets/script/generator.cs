using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] GameObject _circleprefab = default;
    [SerializeField] float _interval = 1f;
    [SerializeField] bool _generatorOnstart = true;
    [SerializeField] int _leftPos;
    [SerializeField] int _rightPos;
    PlayerScore _playerScore;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        if (_generatorOnstart)
        {
            _timer = _interval;
        }
        _playerScore = GetComponent<PlayerScore>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        int random = Random.Range(_leftPos, _rightPos);
        if(_playerScore._count == 1)
        {
            if (_timer > _interval)
            {
                _timer = 0;
                var trashPos = new Vector3(random, transform.position.y, transform.position.z);
                Instantiate(_circleprefab, trashPos, Quaternion.identity);
            }
        }

    }


}
