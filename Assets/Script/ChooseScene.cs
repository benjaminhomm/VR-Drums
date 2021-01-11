using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseScene : MonoBehaviour
{
    // Load Space Scene
    public void StartSpace()
    {
        SceneManager.LoadScene(1);
    }

    // Load Nature Scene
    public void StartNature()
    {
        SceneManager.LoadScene(2);
    }

    // Load Concert Scene
    public void StartConcert()
    {
        SceneManager.LoadScene(3);
    }
}
