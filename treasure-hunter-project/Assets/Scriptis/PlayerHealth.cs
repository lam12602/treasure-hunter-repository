using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //this function is not bulit in and will be called by our own code
    //it must be marked public so other scripts can use it
    public void Kill()
    {
        //this will destroy the game object the script is attached to
        Destroy(gameObject);
    }
}
