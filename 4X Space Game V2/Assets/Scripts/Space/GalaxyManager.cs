using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyManager : MonoBehaviour
{

    public Galaxy Galaxy;

    // Start is called before the first frame update
    void Start()
    {
        Galaxy.ValidateGalaxySettings();
        PopulateRoundGalaxy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PopulateRoundGalaxy(){

        int failCount = 0;
    
        for (int i = 0; i < Galaxy.NumberOfStars; i++){
                Vector3 position = PositionMaths.RandomPolarPosition(Galaxy.MinimumRadius, Galaxy.MaximumRadius);

                Collider[] positionCollider = Physics.OverlapSphere(position, Galaxy.MinDistanceBetweenStars);

                if(positionCollider.Length == 0){
                    Star starData = new Star("Star " + i, Random.Range(1, 10));
                    Debug.Log("Created " + starData.Name + " with " + starData.NumberOfPlanets + " Planets");

                    GameObject starObject = SpaceObjects.CreateSphereObject(starData.Name, position, this.transform);
                    failCount = 0;
                }
                else{
                    i--;
                    failCount++;
                }

                if(failCount > Galaxy.NumberOfStars){
                    Debug.LogError("Could not fit all the Stars into the Galaxy! Try changing settings");
                    break;
                } 
            }
    }
}

/*
Copyright Shadowplay Coding 2019 - see www.shadowplaycoding.com for licensing details
Removing this comment forfits any rights given to the user under licensing.
*/
