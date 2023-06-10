using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorW : MonoBehaviour
{
    [SerializeField] GameObject _circleprefab = default;
    [SerializeField] float _interval = 1f;
    [SerializeField] bool _generatorOnstart = true;
    [SerializeField] int _leftPos;
    [SerializeField] int _rightPos;
    [SerializeField] Open1 _open;
    PlayerScore _playerScore;
    SpriteRenderer _obg = default;

    bool _Active = true;
    //GameObject _cen;
    //Open1 _open;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        _obg = GetComponent<SpriteRenderer>();
        //_cen = GameObject.Find("censor");
        if (_generatorOnstart)
        {
            _timer = _interval;
        }

        PlayerScore _playerScore = GetComponent<PlayerScore>();
    }

    // Update is called once per frame
    void Update()
    {

        _timer += Time.deltaTime;
        int random = Random.Range(_leftPos, _rightPos);
        if (_open._swich == true && _Active == true)
        {
            if (_timer > _interval)
            {
                _obg.color = Color.white;
                _timer = 0;
                var trashPos = new Vector3(random, transform.position.y, transform.position.z);
                Instantiate(_circleprefab, trashPos, Quaternion.identity);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            _Active = true;
            Debug.Log(_Active);
        }
        if (Input.GetMouseButtonDown(1))
        {
            _Active = false;
            Debug.Log(_Active);
        }

    }

}

