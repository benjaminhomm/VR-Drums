using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseScene : MonoBehaviour
{

    public void StartSpace()
    {
        SceneManager.LoadScene(1);
    }

    public void StartNature()
    {
        SceneManager.LoadScene(2);
    }

    public void StartConcert()
    {
        SceneManager.LoadScene(3);
    }
}
