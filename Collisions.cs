
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Collisions : MonoBehaviour
{

    // GameObject collectible = GameObject.FindGameObjectWithTag("collectible");
	// MeshRenderer MeshComponent = gameObject.GetComponent<MeshRenderer>();
	public int collectibleCounter = 0;

    void OnCollisionEnter (Collision collisionInfo){
        
        if (collisionInfo.collider.name == "Ground"){
            Debug.Log("touchdown!");
        }
        if (collisionInfo.collider.tag == "collectible"){
            Debug.Log("collected!");
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

                collectibleCounter = collectibleCounter + 1;
                Debug.Log(collectibleCounter);
            }
        }
    }
}
