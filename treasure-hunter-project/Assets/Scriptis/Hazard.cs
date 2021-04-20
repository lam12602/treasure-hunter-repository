using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object collieded with
        Collider2D objectWeColidedWith = collisionData.collider;
 
        //get the PlayerHealth script if there is one attached
        PlayerHealth player = objectWeColidedWith.GetComponent<PlayerHealth>();

        if (player != null)
        {
            //this means there was a playerhealth script on the object
            //which means the object is the player
            player.Kill();

        }
    }
}
