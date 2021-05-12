using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickUp : MonoBehaviour
{
    //public variable
    public int pickupValue = 1;
    public AudioClip coinSoud;

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(coinSoud, transform.position);
        //Check if score script is attached to thing bumped into
        Score scoreScript = other.GetComponent<Score>();
        if (scoreScript !=null)
        {
            //we have a score script so bumped into player
            scoreScript.AddScore(pickupValue);

            //we should then delete object
            Destroy(gameObject);
        }
    }
}
