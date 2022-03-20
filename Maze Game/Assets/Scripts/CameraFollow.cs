using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    

    private void LateUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");  // Find player object
        if (player != null)
        {
            Vector3 pos = player.transform.position;  // Get player position

            Camera.main.transform.position = new Vector3(pos.x, 5, pos.z);  // Follows the player at a fixed distance
        }
    }
    
}
