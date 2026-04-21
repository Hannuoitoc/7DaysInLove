using UnityEngine;

public class BanhMy : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    public static int trangThai = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isBanhMyCat",true);
                break;
            case 2:
                animator.SetBool("isBanhMyCat",false);
                animator.SetBool("isBanhMyBo",true);
                break;
            case 3:
                animator.SetBool("isBanhMyBo",false);
                animator.SetBool("isBanhMyBoGio",true);
                break;
            case 4:
                animator.SetBool("isBanhMyBoGio",false);
                animator.SetBool("isBanhMyBoGioPate",true);
                break;
            case 5:
                animator.SetBool("isBanhMyBoGioPate",false);
                animator.SetBool("isBanhMyBoGioPateDamBong",true);
                break;
            case 6:
                animator.SetBool("isBanhMyBoGioPateDamBong",false);
                animator.SetBool("isBanhMyBoGioPateDamBongDuaChuot",true);
                break;
            case 7:
                animator.SetBool("isBanhMyBoGioPateDamBongDuaChuot",false);
                animator.SetBool("isBanhMyBoGioPateDamBongDuaChuotRau",true);
                break;
            case 8:
                animator.SetBool("isBanhMyBoGioPateDamBongDuaChuotRau",false);
                animator.SetBool("isBanhMyThanhPham",true);
                break;
        }
    }
    private void OnMouseDown()
    {
        if(trangThai==0||trangThai==7)
            trangThai++;
    }
    
}
