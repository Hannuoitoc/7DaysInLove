using System;
using System.Threading.Tasks;
using UnityEngine;

public class NoiHap : MonoBehaviour
{
    public static int trangThai=0;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    async Task Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isNoiHapSuiCao", true);
                break;
            case 2:
                animator.SetBool("isNoiHapSuiCao", false);
                animator.SetBool("isNoiHapDongNap", true);
                await Task.Delay(4000);
                trangThai = 3;
                break;
            case 3:
                animator.SetBool("isNoiHapDongNap", false);
                animator.SetBool("isNoiHapSuiCaoChin", true);
                break;
        }
    }
    private void OnMouseDown()
    {
        if (trangThai == 1)
            trangThai++;
    }
}
