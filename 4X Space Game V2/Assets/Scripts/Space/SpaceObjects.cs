using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpaceObjects
{
    public static GameObject CreateSphereObject(Vector3 position){
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = position;

        return sphere;
    }
}

/*
Copyright Shadowplay Coding 2019 - see www.shadowplaycoding.com for licensing details
Removing this comment forfits any rights given to the user under licensing.
*/