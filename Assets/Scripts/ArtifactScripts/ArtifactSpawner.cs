using System;
using System.Collections;
using System.Collections.Generic;
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


    float spawnPositionOffset = 1.0f;

    //private void Awake()
    //{
    //    spawnPositionOffset += this.GetObjectRadius();   
    //}
    void Start()
    {
        //StartCoroutine(SpawnArtifactRepeatedly());
        StartCoroutine(SpawnArtifact());
    }

    private void Update()
    {
        if(this.currentSpawned >= this.spawnLimit)
            StopCoroutine(SpawnArtifact());
    }

    IEnumerator SpawnArtifact()
    {
        while (this.currentSpawned <= this.spawnLimit)
        {
            yield return new WaitForSeconds(spawnInterval);

            if (artifact != null)
            {
                Instantiate(artifact, this.RandomizePosition(), Quaternion.identity);

                currentSpawned++;
                Debug.Log("Spawned");
                Debug.Log(currentSpawned.ToString());
            }
            else
            {
                Debug.Log("Prefab to spawn is not assigned!");
            }
        }
    }

    private Vector3 RandomizePosition()
    {
        Bounds targetBounds = spawnBoundary.GetComponent<MeshRenderer>().bounds;

        // Generate random X and Z coordinates within the bounds of spawnBoundary.
        float randomX = UnityEngine.Random.Range(-1.5f, 1.5f);
        float randomZ = UnityEngine.Random.Range(-1.0f, 7.0f);

        // Use the fixed Y coordinate with your spawnPositionOffset.

        Vector3 randomizedPosition = new Vector3(randomX, 1.0f, randomZ);

        return randomizedPosition;
    }

    //Quaternion GetRandomizedRotation()
    //{//only for y and z axes.
    //    Quaternion currentRotation = transform.rotation;

    //    float randomY = UnityEngine.Random.Range(0f, 360f);
    //    float randomZ = UnityEngine.Random.Range(0f, 360f);

    //    Quaternion randomRotation = Quaternion.Euler(currentRotation.eulerAngles.x, randomY, randomZ);

    //    return randomRotation;
    //}

    float GetObjectRadius()
    {
        MeshRenderer renderer = artifact.GetComponent<MeshRenderer>();

        if (renderer != null)
        {
            // Get the radius from the bounds.
            float radius = renderer.bounds.extents.x;
            return radius;
        }
        else
        {
            Debug.LogWarning("No MeshRenderer component found on the object.");
            return 0.0f;
        }
    }
}