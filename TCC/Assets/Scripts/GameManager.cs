using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

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
        }
    }

    void Start()
    {
        LoadScene("Splash");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Level1");
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Level2");
        }

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Level3");
        }
    }

    public void LoadGameAndGUI()
    {
        SceneManager.LoadScene("Game");
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
    }

}