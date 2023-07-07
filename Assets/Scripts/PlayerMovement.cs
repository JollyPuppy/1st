using UnityEngine;

public class PlayerMovement : MonoBehaviour { 

    public Rigidbody rb;

    public float forwardforce = 1000f;  //f is for float numbers. its best to write it.
    public float sidewaysforce = 500f;
    

    // Update is called once per frame
    void FixedUpdate() // unity likes fixedupdate more than update when it comes to physics stuff
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime); // the higher the framerate the lower the value will be of deltatime

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        
            

        if (Input.GetKey ("a"))
            {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
