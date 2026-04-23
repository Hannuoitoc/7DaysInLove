using System;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public static int trangThai=0;
    private Animator animator;
    public static bool donePizzSong=false;
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
                animator.SetBool("isVoBanhCaChua",true);
                break;
            case 2:
                animator.SetBool("isVoBanhCaChua",false);
                animator.SetBool("isVoBanhCaChuaPhoMai",true);
                break;
            case 3:
                animator.SetBool("isVoBanhCaChuaPhoMai",false);
                animator.SetBool("isVoBanhCaChuaPhoMaiNam",true);
                break;
            case 4:
                animator.SetBool("isVoBanhCaChuaPhoMaiNam",false);
                animator.SetBool("isPizzaChuaNuong",true);
                break;
        }
    }

    private void OnMouseDown()
    {

        if (trangThai == 4)
        {
            donePizzSong=true;
        }
    }
}
