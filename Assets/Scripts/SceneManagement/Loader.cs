using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public static class Loader
{
    private class LoadingMonoBehaviour : MonoBehaviour { }
    static Scene _targetScene;
    public enum Scene
    {
        MainMenuScene,
        GameScene,
        LoadingScene,
    }

    private static Action<Scene> onLoaderCallback;
    private static AsyncOperation _loadingAsyncOperation;
     
    public static void Load(Scene targetScene)
    {
        _targetScene = targetScene;
        onLoaderCallback = (targetScene) =>
        {
            GameObject loadingMonoBehaviour = new GameObject("Loading Game Object");
            loadingMonoBehaviour.AddComponent<LoadingMonoBehaviour>().StartCoroutine(LoadSceneAsync(targetScene));
        };

    SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    //private static Action LoadingDelagate(Scene targetScene)
    //{
    //    throw new NotImplementedException();
    //}

    delegate void LoadingDelagate(Scene targetScene);
    //private static LoadingDelagate Loading;
    private static void Loading(Scene targetScene)
    {
        GameObject loadingMonoBehaviour = new GameObject("Loading Game Object");
    loadingMonoBehaviour.AddComponent<LoadingMonoBehaviour>().StartCoroutine(LoadSceneAsync(targetScene));
    }

private static IEnumerator LoadSceneAsync(Scene scene)
    {
        yield return null;
        _loadingAsyncOperation = SceneManager.LoadSceneAsync(scene.ToString());

        _loadingAsyncOperation.allowSceneActivation = false;

        while ( _loadingAsyncOperation.progress <= 0.9f && LoadingUI.CurrentTimer <= LoadingUI.MinTimeToLoad || (_loadingAsyncOperation.isDone && LoadingUI.CurrentTimer <= LoadingUI.MinTimeToLoad))
        {
            LoadingUI.CurrentTimer += Time.deltaTime;
            yield return null;
        }
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
            onLoaderCallback(_targetScene);
            onLoaderCallback = null;
        }
    }
}
