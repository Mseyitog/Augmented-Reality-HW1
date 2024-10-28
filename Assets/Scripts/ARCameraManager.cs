using UnityEngine;

public class ARCameraManager : MonoBehaviour
{
    private static ARCameraManager instance;

    void Awake()
    {
        // Check if an instance of the AR camera already exists
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Destroy this new instance, because one already exists
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Prevent the AR camera from being destroyed across scenes
        }
    }
}
