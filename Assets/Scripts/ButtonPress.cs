using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This scene controls the scenes that load
public class ButtonPress : MonoBehaviour
{
    //Plays sound for button press, loads game
    public void LoadFlappyAnimal()
    {
        SceneManager.LoadScene("FlappyAnimal");
    }

    //Plays sound for button press, loads instructional level
    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
