using UnityEngine;
using UnityEngine.SceneManagement;

public class InputAction : MonoBehaviour
{
    private Scene scene;
    private SoundManager soundManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        soundManager = FindAnyObjectByType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPressEnter()
    {
        if (scene.name != "Gameplay")
        {
            soundManager.SeleccionAudio(0, 0.9f);
            SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
        }
    }

    private void OnPressEscape()
    {
        Application.Quit();
    }
}
