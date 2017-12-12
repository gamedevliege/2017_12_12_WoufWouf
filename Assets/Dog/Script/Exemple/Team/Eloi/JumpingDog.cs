using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingDog : Dog {

    public Rigidbody _affectedRigidbody;
    public float _forceByCm;

    public AudioSource _audioSource;
    

    public override void Bark(float volume, float frequence)
    {
        _audioSource.volume = volume;
        _audioSource.Play();
    }

    public override void Jump(float heighCm)
    {
        _affectedRigidbody.AddForce(Vector3.up * (_forceByCm * heighCm), ForceMode.Impulse);
    }
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
