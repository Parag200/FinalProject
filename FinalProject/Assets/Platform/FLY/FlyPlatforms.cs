using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlatforms : MonoBehaviour
{
    //public array holding platform object
    public GameObject[] objectsToSpawn;

    //function that spawns the objects position and scale 
    public void SpawnObjects(Vector3[] positions, Vector3[] scales)
    {
        for (int i = 0; i < positions.Length; i++)
        {
            GameObject spawnedObject = Instantiate(objectsToSpawn[i], positions[i], Quaternion.identity);
            spawnedObject.transform.localScale = scales[i];
        }   
    }

    //spawning the positions of the platforms 
    Vector3[] spawnPositions = new Vector3[]
    {
     new Vector3(-10,7,2), // Position for object at index 0
     new Vector3(-1, 0, 0), // Position for object at index 1
     new Vector3(4, 7, 2), // Position for object at index 2
     new Vector3(15, -7, 2), // Position for object at index 3

     new Vector3(32, -7, 2), // Position for object at index 4
     new Vector3(41, -7, 2), // Position for object at index 5
     new Vector3(2, 0, 2), // Position for object at index 6
     new Vector3(49, -7, 2), // Position for object at index 7

     new Vector3(63, -4, 3), // Position for object at index 8
     new Vector3(74, -4, 3), // Position for object at index 9
     new Vector3(98, -4, 2), // Position for object at index 10
     new Vector3(106, -4, 2), // Position for object at index 11

     new Vector3(112, -4, -1), // Position for object at index 12
     new Vector3(120, -4, -1), // Position for object at index 13
     new Vector3(125,-4, 3), // Position for object at index 14
     new Vector3(131, -4, 5), // Position for object at index 15

     new Vector3(136, -4, 2), // Position for object at index 16
     new Vector3(144, -4, 2), // Position for object at index 17

    new Vector3(-207,-5,9), // Position for object at index 18 
    new Vector3(-196,-5,9), // Position for object at index 19 
    new Vector3(-195,-4,6), // Position for object at index 20 
    new Vector3(-195,-3,4), // Position for object at index 21 
    new Vector3(-183,-2,6), // Position for object at index 22 


    };

    //spawning the scales of the platforms
    Vector3[] spawnScales = new Vector3[]
    {
     new Vector3(7,1,3), // Position for object at index 0
     new Vector3(1,1,1), // Position for object at index 1
     new Vector3(5,1,3), // Position for object at index 2
     new Vector3(7,1,3), // Position for object at index 3

     new Vector3(3,1,1), // Position for object at index 4
     new Vector3(1,1,1), // Position for object at index 5
     new Vector3(3,1,1), // Position for object at index 6
     new Vector3(7,1,3), // Position for object at index 7

     new Vector3(7,1,2), // Position for object at index 8
     new Vector3(4,1,-2), // Position for object at index 9
     new Vector3(4,1, -2), // Position for object at index 10
     new Vector3(4,1,-2), // Position for object at index 11

     new Vector3(4,1,-2), // Position for object at index 12
     new Vector3(4,1,-2), // Position for object at index 13
     new Vector3(4,1,-2), // Position for object at index 14
     new Vector3(4,1,-2), // Position for object at index 15

     new Vector3(4,1,-2), // Position for object at index 16
     new Vector3(7,1, 2), // Position for object at index 17 

     new Vector3(2,1,2), // Position for object at index 18 
     new Vector3(3,1,2), // Position for object at index 19 
     new Vector3(3,1,2), // Position for object at index 20 
     new Vector3(3,1,2), // Position for object at index 21 
     new Vector3(3,1,2), // Position for object at index 22 
    };

    // Start is called before the first frame update
    void Start()
    {
     
        SpawnObjects(spawnPositions, spawnScales);

    }

    
}
