using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartAR()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
