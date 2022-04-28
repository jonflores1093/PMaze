using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    public GameObject LocationText;


    void Start()
    {
            LocationText.SetActive(false);

    }

    //Once the player goes throught the empty gameobject, it will trigger
    //a text to appear with the location they are currently in
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            LocationText.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
            LocationText.SetActive(false);

    }
}
