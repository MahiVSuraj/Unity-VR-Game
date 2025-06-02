using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    void Start()
    {
        // Subscribe to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene loadedScene, LoadSceneMode mode)
    {
        // This method will be called when a scene finishes loading
        // Debug.Log("Scene loaded: " + loadedScene.name);

        // Perform additional actions or setup related to the newly loaded scene
        // For example, spawn player, initialize UI, etc.
    }

    void OnDestroy()
    {
        // Unsubscribe from the sceneLoaded event when this object is destroyed
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

