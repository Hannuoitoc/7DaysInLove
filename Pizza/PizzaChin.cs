using UnityEngine;
using UnityEngine.SceneManagement;

public class PizzaChin : MonoBehaviour
{
    public bool isClick=false;
    private AudioSource audioSource;
    public AudioClip donedonedoen;
    private bool isAudioPizza=false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
            
    }

    private void OnMouseDown()
    {
        if (isAudioPizza == false)
        {
            isAudioPizza=true;
            GameControlMain.donePizza=true;
        }
    }
}
