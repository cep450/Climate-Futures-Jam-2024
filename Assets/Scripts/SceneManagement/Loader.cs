using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    private class LoadingMonoBehaviour : MonoBehaviour { }

    public enum Scene
    {
        MainMenuScene,
        GameScene,
        LoadingScene,
    }

    private static Action onLoaderCallback;
    private static AsyncOperation _loadingAsyncOperation;

    public static void Load(Scene targetScene)
    {
        onLoaderCallback = () =>
        {
            GameObject loadingMonoBehaviour = new GameObject("Loading Game Object");
            loadingMonoBehaviour.AddComponent<LoadingMonoBehaviour>().StartCoroutine(LoadSceneAsync(targetScene));
        };
       
        SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    private static IEnumerator LoadSceneAsync(Scene scene)
    {
        yield return null;
        _loadingAsyncOperation = SceneManager.LoadSceneAsync(scene.ToString());

        _loadingAsyncOperation.allowSceneActivation = false;

        while ( _loadingAsyncOperation.progress <= 0.9f && LoadingUI.CurrentTimer <= LoadingUI.MinTimeToLoad || (_loadingAsyncOperation.isDone && LoadingUI.CurrentTimer <= LoadingUI.MinTimeToLoad))
        {
            //Debug.Log("Timer " + LoadingUI.CurrentTimer);
            //Debug.Log("Loading " + _loadingAsyncOperation.progress);

            LoadingUI.CurrentTimer += Time.deltaTime;
            yield return null;
        }
        //Debug.Log("Loading " + _loadingAsyncOperation.progress);
        _loadingAsyncOperation.allowSceneActivation = true;
        yield return null;


    }


    public static float GetLoadingProgress()
    {
        if (_loadingAsyncOperation != null)
        {
            if (_loadingAsyncOperation.progress >= 0.9f)
                return 1f;
            return _loadingAsyncOperation.progress;
        }
        else
            return 0f;
    }
    public static void LoaderCallback()
    {
        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}
