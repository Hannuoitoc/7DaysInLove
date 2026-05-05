using UnityEngine;

public class Ending1 : MonoBehaviour
{
    private Animator anim;
    private bool canh1=true;
    private bool canh2=false;
    private bool canh3=false;
    private bool canh4=false;
    private bool canh5=false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (canh1&&Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isEnding1-2",true);
            canh1 = false;
            canh2 = true;
        }
        else if (canh2 && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isEnding1-3",true);
            canh2 = false;
            canh3 = true;
        }
        else if (canh3 && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isEnding1-4",true);
            canh3 = false;
            canh4 = true;
        }
        else if (canh4 && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isEnding1-5",true);
            canh4 = false;
            canh5 = true;
        }
        else if (canh5 && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("ThankYou1",true);
            canh5 = true;
        }
    }
}
