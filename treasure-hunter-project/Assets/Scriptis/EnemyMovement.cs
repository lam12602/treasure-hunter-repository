using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //public varibales
    public float forceStrength; // how fast enemy moves
    public Vector2 direction;
    //private variables
    private Rigidbody2D ourRigidBody;

    //awake is called every time script is first loaded
    void Awake()
    {
        ourRigidBody = GetComponent<Rigidbody2D>();
        direction = direction.normalized;
    }


    // Update is called once per frame
    void Update()
    {
        ourRigidBody.AddForce(direction * forceStrength);
    }
}
