using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public int speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Movement = new Vector3(0, 0, Input.GetAxis("Horizontal"));
       
        this.transform.position += Movement * speed * Time.deltaTime;
    }
}

