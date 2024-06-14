using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour
{
    // This function is called when the collision occurs
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "theox"){
            // Debug.Log("collected!");
            // gameObject.GetComponentInChildren<Renderer>.enabled = false;
        
            MeshRenderer meshRenderer = collisionInfo.gameObject.GetComponent<MeshRenderer>();
            
            // Check if the colliding object has a BoxCollider component
            BoxCollider boxCollider = collisionInfo.gameObject.GetComponent<BoxCollider>();

            // If both the MeshRenderer and BoxCollider exist
            if (meshRenderer != null && boxCollider != null)
            {
                // Disable the MeshRenderer component
                meshRenderer.enabled = false;

                // Disable the BoxCollider component
                boxCollider.enabled = false;
            }
        }
    } 
}
