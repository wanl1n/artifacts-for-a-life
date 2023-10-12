using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

[Serializable]  
public class ArtifactSpawner : MonoBehaviour
{
    public GameObject spawnBoundary;
    public GameObject artifact;
    int currentSpawned = 0;

    [SerializeField]
    float spawnInterval;
    [SerializeField]
    int spawnLimit;

    [SerializeField] private GameObject[] spawnPoints;
    private GameObject[] artifacts;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        StartCoroutine(SpawnArtifact());
    }

    private void Update()
    {
        if(this.currentSpawned >= this.spawnLimit)
            StopCoroutine(SpawnArtifact());


        this.artifacts = GameObject.FindGameObjectsWithTag("Artifact");
        this.currentSpawned = this.artifacts.Length;
    }

    IEnumerator SpawnArtifact()
    {
        while (this.currentSpawned < this.spawnLimit)
        {
            int random = UnityEngine.Random.Range(0, spawnPoints.Length);
            Instantiate(artifact, spawnPoints[random].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}