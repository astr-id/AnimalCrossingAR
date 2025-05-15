using UnityEngine;

public class RibbonColorChangerUI : MonoBehaviour
{
    public Renderer targetRenderer;
    public int materialIndex = 0;

    private Color originalColor;

    void Start()
    {
        if (targetRenderer != null && targetRenderer.materials.Length > materialIndex)
        {
            originalColor = targetRenderer.materials[materialIndex].color;
        }
    }

    public void SetColorRed()
    {
        ChangeColor(Color.red);
    }

    public void SetColorGreen()
    {
        ChangeColor(Color.green);
    }

    public void SetColorBlue()
    {
        ChangeColor(Color.blue);
    }

    public void ResetToOriginalColor()
    {
        ChangeColor(originalColor);
    }

    void ChangeColor(Color newColor)
    {
        if (targetRenderer != null && targetRenderer.materials.Length > materialIndex)
        {
            var mats = targetRenderer.materials;
            mats[materialIndex].color = newColor;
        }
    }
}
