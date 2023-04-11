using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
    public UnityEvent OnloadBegin = new UnityEvent();
    public UnityEvent OnLoadEnd = new UnityEvent();
    //public FadeInAndOut FadeInAndOut = null;
    

    private bool isLoading = false;
    private void Awake()
    {
        SceneManager.sceneLoaded += SetActiveScene;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= SetActiveScene;
    }

    public void LoadNewScene(string sceneName)
    {
        if (!isLoading)
            StartCoroutine(LoadScene(sceneName));
    }

    private IEnumerator LoadScene(string sceneName)
    {
        isLoading = true;

        OnloadBegin?.Invoke();
        //yield return FadeInAndOut.FadeIn();
        yield return StartCoroutine(UnloadCurrent());

        yield return StartCoroutine(LoadNew(sceneName));
        //yield return FadeInAndOut.FadeOut();
        OnLoadEnd?.Invoke();
        isLoading = false;

        
    }

    private IEnumerator UnloadCurrent()
    {
        AsyncOperation unloadOperation = SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

        while(!unloadOperation.isDone)
        
        yield return null;


    }

    private IEnumerator LoadNew(string sceneName)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        while(!loadOperation.isDone)


        yield return null;
    }

    private void SetActiveScene(Scene scene, LoadSceneMode mode)
    {
        SceneManager.SetActiveScene(scene);
    }

}
