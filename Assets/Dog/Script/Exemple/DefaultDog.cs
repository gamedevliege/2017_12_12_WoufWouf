using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultDog : Dog{
    
    public string _name;
    public int _age;
    public enum Sex {M, F}
    public Sex _sex;

    public override void Bark(float volume, float frequence)
    {
        if(volume<0.5f && volume>0f)
            Debug.Log("Wouf, Wouff!");
        else if (volume > 0.5f && volume<1f)
            Debug.Log("WOUF wouf!");
        else if(volume>1)
            Debug.Log("WOUOUOUOUOUOUOUFHFHFFHFFF");
        else
            Debug.LogWarning("No Bark o_O");
    }

    public override void Jump(float heighCm)
    {
        //TODO Add the jump to the dog
        // Can be RigidBody
        // Transform
        // Animation
    }

    public void Start()
    {
        Debug.Log(JsonUtility.ToJson(this));
        PlayerPrefs.SetString("dogage", JsonUtility.ToJson(this));
    }

}
