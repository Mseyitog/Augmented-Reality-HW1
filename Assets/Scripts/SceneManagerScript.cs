using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    async public void LoadScene(string sceneName)
    {
        Debug.Log("sceneName to load: " + sceneName);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
