using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorB : MonoBehaviour
{
    [SerializeField] GameObject _circleprefab = default;
    [SerializeField] float _interval = 1f;
    [SerializeField] bool _generatorOnstart = true;
    [SerializeField] int _leftPos;
    [SerializeField] int _rightPos;
    [SerializeField] Open1 _open;
    [SerializeField] GameObject _obj;
    PlayerScore _playerScore;
    RainColor _RainColor;
    public int _count = 0;
    float _timer;
    public GameObject _rainobj;
    bool _Active = true;
    Color _color;
    // Start is called before the first frame update
    void Start()
    {
        
        PlayerScore _playerScore = GetComponent<PlayerScore>();
        RainColor _rainColor = GetComponent<RainColor>();
        //_cen = GameObject.Find("censor");
        if (_generatorOnstart)
        {
            _timer = _interval;
        }
        //_rainobj = GameObject.Find("rainUp");
        
    }

    // Update is called once per frame
    public void Update()
    {
        _timer += Time.deltaTime;
        int random = Random.Range(_leftPos, _rightPos);
        if (_open._swich == true && _Active == true)
        {
            if (_timer > _interval)
            {
                _count++;
                _timer = 0;
                var trashPos = new Vector3(random, transform.position.y, transform.position.z);
                Instantiate(_circleprefab, trashPos, Quaternion.identity);
            }
        }

        if(Input.GetMouseButtonDown(0))
        {
            _Active = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            _Active = true;
        }
    }

    public Color ChangeColor()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _color = Color.white;
            
        }
        else if (Input.GetMouseButtonDown(1))
        {
            _color = Color.white;
            
        }

        return _color;
    }

}

