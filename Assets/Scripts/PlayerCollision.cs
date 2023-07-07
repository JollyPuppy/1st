using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
     void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacles")
        {
            Debug.Log("Game Over");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
           

        }
    }
}
