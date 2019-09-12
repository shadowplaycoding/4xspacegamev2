using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PositionMaths
{
    // This method creates a random polar coordinate then converts and returns it as a Cartesian coordinate
    public static Vector3 RandomPolarPosition(float minRad, float maxRad){

        float distance = Random.Range(minRad, maxRad);
        float angle = Random.Range(0, (2 * Mathf.PI));

        Vector3 cartPosition = PolarToCart(distance, angle);

        return cartPosition;

    }

    // This method converts a distance and angle (polar coordinates)
    public static Vector3 PolarToCart(float distance, float angle){

        float x = distance * Mathf.Cos(angle);
        float y = 0.0f;
        float z = distance * Mathf.Sin(angle);

        Vector3 cartPosition = new Vector3(x, y, z);

        return cartPosition;

    }
}

/*
Copyright Shadowplay Coding 2019 - see www.shadowplaycoding.com for licensing details
Removing this comment forfits any rights given to the user under licensing.
*/
