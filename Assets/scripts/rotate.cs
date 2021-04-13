using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
 [SerializeField]
    private float angular_speed;
    [SerializeField]
    private float speed=7f;
    protected Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
     
        angular_speed = rb.angularVelocity.magnitude;
        // rb.maxAngularVelocity = float.MaxValue;
        rb.angularVelocity = new Vector3(speed*2, 0, 0);
    }
}
