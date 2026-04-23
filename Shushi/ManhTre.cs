using System;
using Unity.VisualScripting;
using UnityEngine;

public class ManhTre : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    private float hieu = 0;
    public static int trangThai = 0;
    public static bool isDone = false;
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
                animator.SetBool("isManhTreDongBien", true);
                break;
            case 2:
                animator.SetBool("isManhTreDongBien", false);
                animator.SetBool("isManhTreDongBienCom", true);
                break;
            case 3:
                animator.SetBool("isManhTreDongBienCom", false);
                animator.SetBool("isManhTreDongBienComBo", true);
                break;
            case 4:
                animator.SetBool("isManhTreDongBienComBo", false);
                animator.SetBool("isManhTreDongBienComBoCaHoi", true);
                trangThai++;
                break;
            case 5:
                if (hieu>= 5)
                {
                    hieu = 0;
                    animator.SetBool("isManhTreDongBienComBoCaHoi", false);
                    animator.SetBool("isManhTreCuon", true);
                    trangThai++;
                    
                }
                break;
            case 6:
                if (hieu  >= 5)
                {
                    animator.SetBool("isManhTreCuon", false);
                    animator.SetBool("isShushi", true);
                    trangThai++;
                }
                break;
        }
    }

    private void OnMouseDown()
    {
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(trangThai==7)
            isDone=true;
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hieu =Math.Abs(batDauClick.y) + Math.Abs(ketThucClick.y);
    }
}
