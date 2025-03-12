using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewayForce = 2000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.useGravity = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewayForce*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewayForce*Time.deltaTime,0,0);
        }
    }
}

