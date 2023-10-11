using System;
using UnityEngine;


[Serializable]
public class ArtifactCollisionDetector : MonoBehaviour
{
    public GameObject playerCollectionRange;

    public void Update()
    {
        this.checkPlayerCollision();
    }

    // This method is called when a collision occurs.
    private void checkPlayerCollision()
    {
        Bounds playerBounds = playerCollectionRange.GetComponentInChildren<MeshRenderer>().bounds;
        Bounds artifactBounds = this.GetComponentInChildren<MeshRenderer>().bounds;

        if (playerBounds.Intersects(artifactBounds))
        {
            Debug.Log("Player has collided with the artifact.");
            Destroy(this.gameObject);
        }
    }
}