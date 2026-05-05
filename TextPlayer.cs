using TMPro;
using UnityEngine;

public class TextPlayer : MonoBehaviour
{
    private TMP_InputField inputField;
    public static bool doneChat = true;
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }
    
    void Update()
    {
        GeminiAI.question = inputField.text;
        if (Input.GetKeyDown(KeyCode.Return)&&doneChat)
        {
            doneChat = false;
            inputField.text = "";
        }
    }
}
