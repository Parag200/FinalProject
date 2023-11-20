using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //the gameobject of the coin 
    public GameObject coinPrefab;

    //number of coins that will be spawning 
    public int numberOfCoins = 8;

    //user will input the material 
    [SerializeField]
    private Material commonMaterial;

    //grabbing the coindata and sharing it in this class by making a new variable for it
    public CoinData sharedCoinData;

    //on start create new instance of coindata class and the Material in the CoinMATerial function
    private void Start()
    {
        sharedCoinData = new CoinData();
        sharedCoinData.CoinMATerial(commonMaterial);

        //for the number of coins, spawn coins in the the random range vector 3
        for (int i = 0; i < numberOfCoins; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 1.0f, Random.Range(-5f, 5f));
            SpawnCoin(spawnPosition);
        }
    }

    //this functino takes care of spawning the coins 
    private void SpawnCoin(Vector3 position)
    {
        GameObject coinObj = Instantiate(coinPrefab, position, Quaternion.identity);

        //this accesses and changes the game object renderer material 
        Renderer renderer = coinObj.GetComponent<Renderer>();
        //makes sure the renderer is not null as well as the shareddata material 
        if (renderer != null && sharedCoinData.material != null)
        {
           renderer.material = sharedCoinData.material;
           
            
        }

        //if renderer is null and material show error
        else if (renderer == null && sharedCoinData.material == null)
        {
           
        Debug.Log("Error null Renderer");
            
        }
    }

   
}
