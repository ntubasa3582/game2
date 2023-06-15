using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotate : MonoBehaviour
{
    [SerializeField]
    float rotSpeed = 0.1f;
    public AudioClip _audioClip;
    AudioSource _audioSource;
    bool _swicth;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        // transform���擾
        Transform myTransform = this.transform;

        // ���[���h���W��ŁA���݂̉�]�ʂ։��Z����
        if(_swicth == true )
        {
            myTransform.Rotate(0f, 0f, rotSpeed);
        }
        if(_swicth == false )
        {
            myTransform.Rotate(0f, 0f, -rotSpeed);
        }
        if(Input.GetMouseButton(0))
        {
            //_audioSource.PlayOneShot(_audioClip);
            _swicth = true;
        }
        if (Input.GetMouseButton(1))
        {
            _swicth = false;
        }
    }
}
