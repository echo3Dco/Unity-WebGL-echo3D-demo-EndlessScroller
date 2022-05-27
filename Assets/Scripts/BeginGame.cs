using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Changes scenes from StartGame and OpeningScene
public class BeginGame : MonoBehaviour
{

    //After 5 seconds, game is invoked
    void Update()
    {
        Invoke("StartGame", 5.0f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("OpeningScene");
    }
}
