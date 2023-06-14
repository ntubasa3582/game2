using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale2 : MonoBehaviour
{
    int _rox;
    int _roy;
    int _roz;
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0f, 0f, -45f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0f, 0f, 45f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }
}
