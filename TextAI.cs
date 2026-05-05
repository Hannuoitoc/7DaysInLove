using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = GeminiAI.answer;
    }
}
