using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeReference]public static int MonAn = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
    }
}
