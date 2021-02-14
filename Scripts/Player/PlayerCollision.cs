using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Guard" || collisionInfo.collider.tag == "Wall")
        {
            movement.enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();
        }

    }
}
