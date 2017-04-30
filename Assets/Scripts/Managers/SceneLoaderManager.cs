using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderManager : MonoBehaviour
{
    [SerializeField]
    private string[] scenes;

    private void Start()
    {
        foreach (var scene in scenes)
        {
            Load(scene);
        }
        
        Debug.Log("Scenes loaded");
    }

    private void Load(int sceneIndex)
    {
        if (!SceneManager.GetSceneByBuildIndex(sceneIndex).isLoaded)
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }

    private void Load(string sceneName)
    {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    private void Unload(int sceneIndex)
    {
        if (SceneManager.GetSceneByBuildIndex(sceneIndex).isLoaded)
            SceneManager.UnloadSceneAsync(sceneIndex);
    }

    private IEnumerator Unload(int sceneIndex, float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);

        if (SceneManager.GetSceneByBuildIndex(sceneIndex).isLoaded)
            SceneManager.UnloadSceneAsync(sceneIndex);
    }

    private void Unload(string sceneName)
    {
        if (SceneManager.GetSceneByName(sceneName).isLoaded)
            SceneManager.UnloadSceneAsync(sceneName);
    }

    private IEnumerator Unload(string sceneName, float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);

        if (SceneManager.GetSceneByName(sceneName).isLoaded)
            SceneManager.UnloadSceneAsync(sceneName);
    }
}
