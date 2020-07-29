using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loadNextLevel", 2f);   
    }

    void loadNextLevel()
    {
        SceneManager.LoadScene(1);
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
