using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;
    float moveHorz;
    float moveVert;



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

    void OnTriggerEnter(Collider col)
    {
        //Once the player collects all 10 keys, if the player touches the exit it will destory the object
        if (col.gameObject.name == "Exit" && Keys.collectedKeys == 10) 
        {
            Destroy(col.gameObject);
        }

        //Makes it so that the EndGame empty object loads end scene once triggered
        if (col.gameObject.name == "EndGame") 
        {
            SceneManager.LoadScene(2);
        }
    }



}



