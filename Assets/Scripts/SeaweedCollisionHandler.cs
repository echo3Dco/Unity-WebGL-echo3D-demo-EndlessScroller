using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script details what happens when collides with seaweed
public class SeaweedCollisionHandler : MonoBehaviour
{
    //Scene reloads on collision
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("GameOver");
    }
}
