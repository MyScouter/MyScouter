using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGame : MonoBehaviour
{
    #region singelton
    public static SceneManagerGame instance;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance != null)
            return;
        instance = this;
    }

    #endregion

    public static int numScene=0;
    public void LoadNextScene(int num)
    {
        
        SceneManager.LoadScene(num);
    }
}
