using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Slider levelProgress;

    public void loadLevel(string sceneName)
    {
        StartCoroutine( LoadAsync(sceneName) );
    }

    IEnumerator LoadAsync (string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            levelProgress.value = progress;

            yield return null;

        }

    }

}
