using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class InfoTextReader : MonoBehaviour
{
    public TextMeshProUGUI infoText;
    [TextArea]
    public string fullText;

    public float delay = 0.05f;

    public AudioSource audioSource;
    public AudioClip[] letterSounds; 

    private void OnEnable()
    {
        infoText.text = "";
        StartCoroutine(TypeTextWithSound(fullText));
    }

    IEnumerator TypeTextWithSound(string text)
    {
        foreach (char c in text)
        {
            infoText.text += c;

            if (char.IsLetter(c))
            {
                int index = char.ToUpper(c) - 'A';
                if (index >= 0 && index < letterSounds.Length)
                    audioSource.PlayOneShot(letterSounds[index]);
            }

            yield return new WaitForSeconds(delay);
        }
    }
}