using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject platformPrefabBlue;


    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();
        for (int i = 0; i < 10; i++)                
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);  
            SpawnerPosition.y += Random.Range(2f, 4f);     

            int Rand_Platform = Random.Range(1, 10);

            if (Rand_Platform == 1 || Rand_Platform == 2) 
                Instantiate(platformPrefabBlue, SpawnerPosition, Quaternion.identity);
            else 
                Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }


}
