using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Galaxy
{
    public int NumberOfStars = 300;
    public int MinimumRadius = 0;
    public int MaximumRadius = 100;
    public float MinDistanceBetweenStars = 2f;

    public void ValidateGalaxySettings(){
        
        if (MinimumRadius > MaximumRadius){
            int tempValue = MaximumRadius;
            MaximumRadius = MinimumRadius;
            MinimumRadius = tempValue;
        }

    }
}

/*
Copyright Shadowplay Coding 2019 - see www.shadowplaycoding.com for licensing details
Removing this comment forfits any rights given to the user under licensing.
*/
