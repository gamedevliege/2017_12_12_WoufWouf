using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDog : Dog {
    
    #region Public Members

    public Rigidbody m_rigidbody;
    public float m_thrust;

    public AudioSource m_audioSource;

    #endregion

    #region Public void

    public override void Bark(float volume, float frequence)
    {
        Debug.Log(volume);
    }

    public override void Jump(float heighCm)
    {
        m_rigidbody.AddForce(Vector3.up * heighCm * m_thrust, ForceMode.Impulse);
    }

    #endregion

    #region System

    void Start()
    {
		
	}
	
	void Update()
    {
		
	}

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private an Protected Members

    #endregion
}