using UnityEngine;
using UnityEngine.SceneManagement;

public class ARMenuManager : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
