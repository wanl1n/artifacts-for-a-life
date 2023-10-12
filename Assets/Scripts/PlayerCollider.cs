using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    private bool collided = false;
    private Collider other = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lantern" || other.gameObject.tag == "Ladder")
        {
            collided = true;
            this.other = other;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Lantern" || other.gameObject.tag == "Ladder")
        {
            collided = false;
            this.other = null;
        }
    }

    private void Update()
    {
        if (collided && this.other != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.other.GetComponent<ToolScript>().use();
            }

        }
    }
}