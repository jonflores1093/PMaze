using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedDisplay : MonoBehaviour
{
    
    //Once the player touches a key, it will destroy the object and add 1 to its counter
    void OnTriggerEnter(Collider other)
    {

        Keys.collectedKeys += 1;//This is referencing the "Keys" script that houses "collectedKeys" and adds 1 to the counter
        Destroy(gameObject);

        
    }
}
