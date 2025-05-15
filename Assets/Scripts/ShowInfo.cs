using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject panelInfo;
    public GameObject[] otherButtons;

    public void ShowInfoPanel()
    {
        panelInfo.SetActive(true);

        foreach (GameObject btn in otherButtons)
        {
            btn.SetActive(false);
        }
    }

    public void HideInfoPanel()
    {
        panelInfo.SetActive(false);

        foreach (GameObject btn in otherButtons)
        {
            btn.SetActive(true);
        }
    }
}