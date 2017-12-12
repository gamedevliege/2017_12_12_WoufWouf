using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Dog : MonoBehaviour, IDog{


    public abstract void Bark(float volume, float frequence);

    public abstract void Jump(float heighCm);
   

    void Start ()
    {
        Debug.Log("Created Dog");
        
    }
    void OnDestroy() {

        Debug.Log("Sprouch Dog");
    }


    
}
