using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDD_Dog : MonoBehaviour{
    #region Public Members


    [SerializeField]
    private Dog _dog;
    private IDog _dogInterface;

    [SerializeField]
    private float _timeBetweenJumpMin =0.1f;
    [SerializeField]
    private float _timeBetweenJumpMax =5f;

    [SerializeField]
    private float _timeBetweenBarkMin=0.5f;
    [SerializeField]
    private float _timeBetweenBarkMax=3f;


 



    #endregion

    #region Public void

    #endregion

    #region System

    //void OnValidate ()
    //{
    //    if (_dog != null) {
    //        _dogInterface = _dog.GetComponent<IDog>();
    //    }
    //}

    void Start ()
    {

        StartCoroutine(DoBark());
        StartCoroutine(Jump());
    }

    private IEnumerator DoBark()
    {
        while (true)
        {
            yield return new WaitForSeconds(
               UnityEngine.Random.Range(_timeBetweenBarkMin, _timeBetweenBarkMax));
            _dog.Jump(UnityEngine.Random.Range(0, 200));

        }

    }
    private IEnumerator Jump()
    {
        while (true)
        {
            yield return new WaitForSeconds(
                UnityEngine.Random.Range(_timeBetweenBarkMin, _timeBetweenBarkMax));
            _dog.Bark(UnityEngine.Random.Range(-0.5f, 2f), UnityEngine.Random.Range(0, 1000));
        }

    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
