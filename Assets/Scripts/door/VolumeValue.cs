using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class VolumeСhange : MonoBehaviour
{
    private AudioSource _audioSource;
    private float _maxVolume = 1;
    private float _musicVolume = 0.1f;
    private float _minVolume = 0.1f;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(VolumeChange()); ;
    }

    private IEnumerator VolumeChange()
    {
        _audioSource.volume = _musicVolume;
        while (true)
        {
            if (_musicVolume < _maxVolume)
            {
                _musicVolume = Mathf.MoveTowards(_minVolume, _maxVolume, _musicVolume * Time.deltaTime);
            }

            else if (_musicVolume > _maxVolume)
            {
                _musicVolume = Mathf.MoveTowards(_maxVolume, _minVolume, _musicVolume * Time.deltaTime);
            }
            yield return null;
        }
    }

}
