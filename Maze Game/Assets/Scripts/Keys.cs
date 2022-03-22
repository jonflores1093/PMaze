using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    public GameObject collectedText;
    public static int collectedKeys;
   

    //Starts the game with a text box stating number of keys collected
    void Update()
    {

        collectedText.GetComponent<Text>().text = "Keys Collected: " + collectedKeys;
        
    }


}
