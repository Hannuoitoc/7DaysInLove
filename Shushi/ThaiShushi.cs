using UnityEngine;

public class ThaiShushi : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    private int trangThai = 0;
    private float hieu = 0;
    public static bool isDone=false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (batDauClick.x >= 0.5 && batDauClick.x <= 1.2 && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 0)
        {
            animator.SetBool("isShushi1",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= 0 && batDauClick.x <= 0.7 && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 1)
        {
            animator.SetBool("isShushi1",false);
            animator.SetBool("isShushi2",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -0.5 && batDauClick.x <= 0.2 && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 2)
        {
            animator.SetBool("isShushi2",false);
            animator.SetBool("isShushi3",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -0.8 && batDauClick.x <= -0.2 && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 3)
        {
            animator.SetBool("isShushi3",false);
            animator.SetBool("isShushi4",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -1.3 && batDauClick.x <= -0.7 && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 4)
        {
            animator.SetBool("isShushi4",false);
            animator.SetBool("isShushi5",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -1.8 && batDauClick.x <= -1.2  && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 5)
        {
            animator.SetBool("isShushi5",false);
            animator.SetBool("isShushi6",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -2.3 && batDauClick.x <= -1.6  && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 6)
        {
            animator.SetBool("isShushi6",false);
            animator.SetBool("isShushi7",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -2.8 && batDauClick.x <= -2.1  && batDauClick.y >= 0.5 && hieu >= 1 && trangThai == 7)
        {
            animator.SetBool("isShushi7",false);
            animator.SetBool("isShushi8",true);
            hieu = 0;
            trangThai++;
        }
    }
    private void OnMouseDown()
    {
        batDauClick=Vector2.zero;
        ketThucClick=Vector2.zero;  
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(trangThai==8)
            isDone=true;
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hieu = batDauClick.y - ketThucClick.y;
    }
}
