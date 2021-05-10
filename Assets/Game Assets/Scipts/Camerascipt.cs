using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascipt : MonoBehaviour
{
    public Transform player;
    
      
    // Keeps camera on player without parenting them
    private void Update()
    {
        
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
