using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star
{
    public string Name {get; protected set;}
    public int NumberOfPlanets {get; protected set;}

    public Star(string name, int numberOfPlanets){
        this.Name = name;
        this.NumberOfPlanets = numberOfPlanets;
    }
}

/*
Copyright Shadowplay Coding 2019 - see www.shadowplaycoding.com for licensing details
Removing this comment forfits any rights given to the user under licensing.
*/
