using UnityEngine;

public class Ending4 : MonoBehaviour
{
    private Animator anim;
    private bool canh1=true;
    private bool canh2=false;
    private bool canh3=false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (canh1&&Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isEnding4-2",true);
            canh1 = false;
            canh2 = true;
        }
        else if (canh2 && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isEnding4-3",true);
            canh2 = false;
            canh3 = true;
        }
        else if (canh3 && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("ThankYou4",true);
            canh3 = false;
        }
    }
}
