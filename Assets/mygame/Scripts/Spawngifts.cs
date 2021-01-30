using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawngifts : MonoBehaviour
{
    public GameObject giftPrefab;
    public GameObject parentSpawngift;

    private float spawnRate = 3f;
    private float nextSpawn = 4f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnTheGift();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheGift();
        }
    }

    private void SpawnTheGift()
    {
        var clones = Instantiate(giftPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawngift.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-380, 380), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f,0.5f,0.5f) ;
    }

        
}
