using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script controls fishs and their randomized positions
public class Fish : MonoBehaviour
{
    private float moveSpeed = 2f;

    //Starts fish all over in first frame 1 time
    private void Start()
    {
        Reset();
    }

    void Update()
    {
        //Generates new fish over 10 value for y
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        if (transform.position.y > 10)
        {
            Reset();
        }
    }

    //Triggers these actions once something passes through the fish collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (OtherIsTheFish(other))
        {
            print("Fish hit");
            //Go into the other script Scorekeeper and reference nested IncrementScore method
            Scorekeeper scoreKeeper = GameObject.FindObjectOfType<Scorekeeper>();
            scoreKeeper.IncrementScore();
            Reset();
           }
    }
    
    //Resets position of each new fish
    void Reset()
    {
        //Creates random y value for fish
        float randomHeight = Random.Range(-5f, -15f);
        transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
    }

    //References object so the game doesn't try to collect something that isn't there = console warnings
    bool OtherIsTheFish(Collider2D other)
    {
         return (other.GetComponent<SharkController>() != null);
    }
}
