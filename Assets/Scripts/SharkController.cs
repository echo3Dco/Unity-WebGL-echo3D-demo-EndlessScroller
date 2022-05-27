using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script controls the fish and input
public class SharkController : MonoBehaviour
{
    //References how fast the shark goes over time and distance
    [SerializeField]
    private float upwardForceMultiplier = 200f;

    void Update()
    {
        // Space key input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //This gets the rigidbody from the shark so we can interact with it
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            // First stop the rigidbody, then sets velocity at 0 in every direction
            rigidbody.velocity = Vector3.zero;
            // Add upward force
            rigidbody.AddForce(Vector2.up * upwardForceMultiplier);
        }

        // Easy script for a player being out of a set range and resetting, if player is over or under 6, load level
        if (transform.position.y > 6f || transform.position.y < -6f)
        {
            SceneManager.LoadScene("FlappyAnimal");
        }
    }
}
