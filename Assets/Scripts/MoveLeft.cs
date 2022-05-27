using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script moves the seaweed left (not fish)
public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.5f;
    [SerializeField]
    private bool randomizeHeight = true;

    //Parameters for seaweed moving left
    void Update()
    {
        //Moves environment to the left
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //This resets the seaweed formation once they go out of view
        if (transform.position.x < -15)
        {
            //Creates new position once parameter is hit
            if (randomizeHeight)
            {
                //This is randomize script, to change Y position of seaweed randomly between -2 and 2
                float randomYposition = UnityEngine.Random.Range(-2, 2);
                transform.position = new Vector3(15, randomYposition, 0);
            }
            else
            {
                transform.position = new Vector3(15, transform.position.y, 0);
            }
        }
    }
}
