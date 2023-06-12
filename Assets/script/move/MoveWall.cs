using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] float _pos;
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
        transform.position = new Vector2(Mathf.Sin(Time.time) * _pos + 150 ,_posy);
    }
}
