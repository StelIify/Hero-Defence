using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    float waitTime = 3f;
    int currentSceneIndex;
    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        StartCoroutine(StartMainMenu());
    }
    
    private IEnumerator StartMainMenu()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadNextScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
