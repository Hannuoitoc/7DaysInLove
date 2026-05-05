using System;
using UnityEngine;

public class ShowEClick : MonoBehaviour
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
        if (other.tag == "Player")
        {
            EclickVatThe.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            EclickVatThe.SetActive(false);
        }
    }
}
