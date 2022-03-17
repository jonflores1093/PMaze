using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;
    void Start()
    {
        rigb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        float moveHorz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider collision)
    {
        print("item collected");
        if (collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
        }
    }

}



