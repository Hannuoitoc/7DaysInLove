using UnityEngine;

public class ThitBam : MonoBehaviour
{
    public static bool isClick = false;
    private Animator animator;
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
                animator.SetBool("isThitBamHanh",true);
                break;
            case 2:
                animator.SetBool("isThitBamHanh",false);
                animator.SetBool("isThitBamHanhTom",true);
                break;
            case 3:
                animator.SetBool("isThitBamHanhTom",false);
                animator.SetBool("isThitBamHanhTomTron",true);
                trangThai++;
                break;
            
        }
    }
    private void OnMouseDown()
    {
        if(trangThai==2)
            trangThai++;
        
        if (VoBanh.trangThai==0&&trangThai==4)
        {
            isClick=true;
        }
    }

    private void OnMouseUp()
    {
        isClick=false;
    }
}
