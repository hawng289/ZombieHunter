using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject[] spawnPoints;
    public GameObject zombie;
    public float timeSpawnMax;
    float timeSpawnLast;
    float timeSpawn;
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
        UpdateTimeSpawnLast();
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    private void UpdateTimeSpawnLast()
    {
        timeSpawnLast = Time.time;
        timeSpawn = Random.Range(0, timeSpawnMax);
    }

    private void Spawn()
    {
        if (timeSpawnLast +  timeSpawn < Time.time)
        {
            
            int postion = Random.Range(0, spawnPoints.Length);
            UpdateTimeSpawnLast();
            Instantiate(zombie, spawnPoints[postion].transform.position, Quaternion.identity);
        }
        
    }
}
