using System;
using TMPro;
using UnityEngine;

[Serializable]
public class ArtifactCollisionDetector : MonoBehaviour
{
    public PlayerStatsManager playerStatsManager;
    public GameObject playerCollectionRange;
    public GameObject score; // Change the variable type to GameObject

    public void Update()
    {
        CheckPlayerCollision();
    }

    private void CheckPlayerCollision()
    {
        Bounds playerBounds = playerCollectionRange.GetComponentInChildren<MeshRenderer>().bounds;
        Bounds artifactBounds = GetComponentInChildren<MeshRenderer>().bounds;

        if (playerBounds.Intersects(artifactBounds))
        {
            IncrementScore();
            Destroy(gameObject);
        }
    }

    private void IncrementScore()
    {
        playerStatsManager.artifactsCollected++;
    }
}
