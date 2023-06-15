using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip _clip;
    Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ClickSound()
    {
        _audioSource.PlayOneShot(_clip);
    }
}
