using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    public Camera myCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") || Input.touchCount > 0)
        {
            Vector3 forward = myCamera.transform.forward;
            this.transform.position += forward * Time.deltaTime * speed;
            rb.AddForce(forward * speed);
        }
    }
}
