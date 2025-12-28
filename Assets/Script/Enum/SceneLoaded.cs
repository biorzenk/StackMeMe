using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaded : MonoBehaviour
{
   public static SceneLoaded Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void Load(SceneType scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }



    public void Reload()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
