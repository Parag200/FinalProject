using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWeightPattern : MonoBehaviour
{
    //array of game objects incase we want to spawn mulitple different objects 
    public GameObject[] Prefabs;

    public int SpawnPlat;
    public int UIx;
    public int UIy;
    public int UIz;

    

    public void Spawn(int numPlat)
    {

        //instatiate prefab of certain array type with its position 
        GameObject instance = Instantiate(Prefabs[numPlat]);
        instance.transform.position = new Vector3(UIx,UIy,UIx);
        
        
    }

    

    public void Start()
    {
        //spawning object in the array position value of SpawnPlat set by the player
        Spawn(SpawnPlat - 1);
    }
   
}
