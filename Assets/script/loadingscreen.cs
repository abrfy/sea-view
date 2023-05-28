using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingscreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loadingScene;
    public Slider loadingBar;

    public void LoadScreen(int level)
    {
        StartCoroutine(LoadScreenAsynchronously(level));
    }
    IEnumerator LoadScreenAsynchronously(int level)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(level);
        loadingScene.SetActive(true);
        while (!operation.isDone)
        {
            loadingBar.value = operation.progress;
            yield return null;
        }
    }
}
