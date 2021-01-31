using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnenemy : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    public GameObject parentSpawnenemy;

    private float spawnRate = 3f;
    private float nextSpawn = 6f;



    // Start is called before the first frame update
    void Start()
    {
        SpawnTheEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheEnemy();
        }
    }

    private void SpawnTheEnemy()
    {
        var clones = Instantiate(enemyPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnenemy.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-240, 240), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }


}
