using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    bool _swicth;

    void Update()
    {
        // transform���擾
        Transform myTransform = this.transform;

        // ���[���h���W��ŁA���݂̉�]�ʂ։��Z����
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
