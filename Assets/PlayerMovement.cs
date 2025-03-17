using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewayForce = 2000f;
    public ParticleSystem groundImpactFX;
    private bool hasLanded = false; 

    void Start()
    {
        rb.useGravity = true;
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!hasLanded && collision.gameObject.CompareTag("Ground"))
        {
            groundImpactFX.Play();
            hasLanded = true;
        }
    }
}
