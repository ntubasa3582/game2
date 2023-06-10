using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    bool _swicth;

    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        // ワールド座標基準で、現在の回転量へ加算する
        if(_swicth == true )
        {
            myTransform.Rotate(0f, 0f, 0.1f);
        }
        if(_swicth == false )
        {
            myTransform.Rotate(0f, 0f, -0.1f);
        }
        if(Input.GetMouseButton(0))
        {
            _swicth = true;
        }
        if (Input.GetMouseButton(1))
        {
            _swicth = false;
        }
    }
}
