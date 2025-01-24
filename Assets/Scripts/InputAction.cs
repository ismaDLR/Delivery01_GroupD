using UnityEngine;
using UnityEngine.SceneManagement;

public class InputAction : MonoBehaviour
{
    private Scene scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPressEnter()
    {
        if (scene.name != "Gameplay")
        {
            SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
        }
    }

    private void OnPressEscape()
    {
        Application.Quit();
    }
}
