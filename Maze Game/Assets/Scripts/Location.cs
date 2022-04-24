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
