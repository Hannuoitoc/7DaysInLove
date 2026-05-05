using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class NgonNgu : MonoBehaviour
{
    
    private TextMeshProUGUI text;
    void Start()
    {
    }
    
    void Update()
    {
        if (text == null)
        {
            text = gameObject.transform.Find("NgonNgu").GetComponent<TextMeshProUGUI>();
        }
        if (GameControlMain.ngonNgu == 2)
        {
            text.SetText("English");
        }
        else if (GameControlMain.ngonNgu == 1)
        {
            text.SetText("Việt Nam");
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (GameControlMain.ngonNgu == 1)
            {
                GameControlMain.ngonNgu = 2;
            }
            else if (GameControlMain.ngonNgu == 2)
            {
                GameControlMain.ngonNgu = 1;
            }
        }
    }
    
}
