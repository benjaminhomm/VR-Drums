using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseScene : MonoBehaviour
{
    // Load Space Scene
    public void StartSpace()
    {
        StartCoroutine(loadScene(1));
    }

    // Load Nature Scene
    public void StartNature()
    {
        StartCoroutine(loadScene(2));
    }

    // Load Concert Scene
    public void StartConcert()
    {
        StartCoroutine(loadScene(3));
    }

    // Load the Scene with the given parameter
    IEnumerator loadScene(int scene) {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scene);
    }
}
