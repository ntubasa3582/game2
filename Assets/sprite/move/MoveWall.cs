using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] float _posx;
    [SerializeField] float _posy;
    private Vector3 targetpos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Cos(Time.time) * _posx +  322,_posy);
        //transform.position = new Vector2(Mathf.Cos(Time.time) * _pos + 322, _posy);
    }
}
