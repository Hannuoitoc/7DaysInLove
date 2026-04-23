using UnityEngine;
using UnityEngine.SceneManagement;

public class PizzaChin : MonoBehaviour
{
    public bool isClick=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnMouseDown()
    {
        GameControlMain.donePizza=true;
    }
}
