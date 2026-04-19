using Unity.VisualScripting;
using UnityEngine;

public class ManhTre : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Shushi.trinhTuLamShushi)
        {
            case 6:
                animator.SetBool("isManhTreDongBien", true);
                break;
            case 5:
                animator.SetBool("isManhTreDongBien", false);
                animator.SetBool("isManhTreDongBienCom", true);
                break;
            case 4:
                animator.SetBool("isManhTreDongBienCom", false);
                animator.SetBool("isManhTreDongBienComBo", true);
                break;
            case 3:
                animator.SetBool("isManhTreDongBienComBo", false);
                animator.SetBool("isManhTreDongBienComBoCaHoi", true);
                Shushi.trinhTuLamShushi--;
                break;
            case 2:
                if (ketThucClick.y - batDauClick.y >= 5)
                {
                    animator.SetBool("isManhTreDongBienComBoCaHoi", false);
                    animator.SetBool("isManhTreCuon", true);
                    Shushi.trinhTuLamShushi--;
                }
                break;
            case 1:
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
