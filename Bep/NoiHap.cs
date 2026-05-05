using System;
using System.Threading.Tasks;
using UnityEngine;

public class NoiHap : MonoBehaviour
{
    public static int trangThai=0;
    private Animator animator;
    public static bool isClick=false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isNoiHapSuiCao", true);
                break;
            case 2:
                animator.SetBool("isNoiHapSuiCao", false);
                animator.SetBool("isNoiHapDongNap", true);
                GameControlMain.instance.WaitAndDo(3f, () => {
                   trangThai = 3;     
                });
                break;
            case 3:
                animator.SetBool("isNoiHapDongNap", false);
                animator.SetBool("isNoiHapSuiCaoChin", true);
                break;
        }
    }
    private void OnMouseDown()
    {
        isClick=true;
        if (trangThai == 1)
            trangThai++;
    }

    private void OnMouseUp()
    {
        isClick=false;
    }
}
