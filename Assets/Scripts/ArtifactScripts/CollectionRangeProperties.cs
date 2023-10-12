using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionRangeProperties : MonoBehaviour
{
    void Start()
    {
        Vector3 newPosition = this.transform.position; // Get the current position
        newPosition.y = this.GetComponentInParent<MeshRenderer>().bounds.max.y; // Update the Y component
        this.transform.position = newPosition; // Set the new position

        Vector3 newScale = this.transform.localScale;
        newScale.y = this.GetComponentInParent<MeshRenderer>().bounds.max.y*3;
        this.transform.localScale = newScale;
    }

}
