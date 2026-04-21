using Unity.VisualScripting;
using UnityEngine;

public class ManhTre : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    public static int trangThai = 0;
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
                if (ketThucClick.y - batDauClick.y >= 5)
                {
                    animator.SetBool("isManhTreDongBienComBoCaHoi", false);
                    animator.SetBool("isManhTreCuon", true);
                    trangThai++;
                }
                break;
            case 6:
                if (batDauClick.y - ketThucClick.y  >= 5)
                {
                    animator.SetBool("isManhTreCuon", false);
                    animator.SetBool("isShushi", true);
                }
                break;
        }
    }

    private void OnMouseDown()
    {
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
