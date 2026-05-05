using System;
using UnityEngine;

public class ShowEClickEnding : MonoBehaviour
{
    public GameObject EclickVatThe;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player"&&GameControlMain.Day==7)
        {
            EclickVatThe.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player"&&GameControlMain.Day==7)
        {
            EclickVatThe.SetActive(false);
        }
    }
}
