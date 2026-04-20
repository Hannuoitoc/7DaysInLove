using Unity.VisualScripting;
using UnityEngine;

public class Shushi : MonoBehaviour
{
    [SerializeReference]public static int trinhTuLamShushi=7;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.MonAn == 5)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
    }
}
