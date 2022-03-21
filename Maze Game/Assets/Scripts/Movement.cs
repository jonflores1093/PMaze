using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;
    float moveHorz;
    float moveVert;
    private int itemCount;
    

    void Start()
    {
        rigb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        //Gets axis of player
        moveHorz = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");


    }
    void FixedUpdate() 
    {
        //Allows for the player to move using standard input
        Vector3 movement = new Vector3(moveHorz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
        

    }




    //When an object is touched by the player, it will collect it and increase counter
    private void OnTriggerEnter(Collider collision)
    {
        print("item collected");
        if (collision.CompareTag("Key"))
        {
            
            Destroy(collision.gameObject);
            itemCount++;
        }
    }

    //Creates a text box displaying amount of keys collected
    private void OnGUI()
    {
        GUI.Label(new Rect(1, 1, 200, 30), "Keys Collected: " + itemCount);
    }

}



