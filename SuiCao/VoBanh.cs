using UnityEngine;

public class VoBanh : MonoBehaviour
{
    public static int trangThai=0;
    private Animator animator;
    public static bool isClick=false;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isVoBanhNhan",true);
                break;
            case 2:
                animator.SetBool("isVoBanhNhan",false);
                animator.SetBool("isSuiCaoSong",true);
                break;
        }
    }

    private void OnMouseDown()
    {
        if (trangThai == 2)
        {
            isClick=true;
        }
        if(trangThai==1)
            trangThai++;
    }

    private void OnMouseUp()
    {
        isClick=false;
    }
    
}
