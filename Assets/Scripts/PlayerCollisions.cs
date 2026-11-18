using UnityEngine;

public class PlayerColisions : MonoBehaviour
{
    [SerializeField] private playermovement playerMovementScript;

   void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("On a touché " + collisionInfo.collider.name);
            playerMovementScript.enabled = false;
        }    
       
    }
}
