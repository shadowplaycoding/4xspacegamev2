using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyManager : MonoBehaviour
{

    public Galaxy Galaxy;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < Galaxy.NumberOfStars; i++)
        {
            Vector3 position = PositionMaths.RandomPolarPosition(0, Galaxy.MaximumRadius);
            GameObject starObject = SpaceObjects.CreateSphereObject(position);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
Copyright Shadowplay Coding 2019 - see www.shadowplaycoding.com for licensing details
Removing this comment forfits any rights given to the user under licensing.
*/
