using System.Threading.Tasks;
using UnityEngine;

public class ThaiBiNgoi : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    private int trangThai = 0;
    private float hieu = 0;
    public static bool active = false;
    public static bool isDone = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    async Task Update()
    {
        if (batDauClick.y >= -1 && batDauClick.y <= 0.8 && batDauClick.x <= -2.5 && ketThucClick.x-batDauClick.x >= 5.4&&trangThai==0)
        {
            animator.SetBool("isBiNgoi1",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= 1.6 && batDauClick.x <= 2.4 && batDauClick.y >= 1 && hieu >= 1.8 && trangThai == 1)
        {
            animator.SetBool("isBiNgoi1",false);
            animator.SetBool("isBiNgoi2",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= 0.8 && batDauClick.x <= 1.6 && batDauClick.y >= 1 && hieu >= 1.8 && trangThai == 2)
        {
            animator.SetBool("isBiNgoi2",false);
            animator.SetBool("isBiNgoi3",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= 0.1 && batDauClick.x <= 0.8 && batDauClick.y >= 1 && hieu >= 1.8 && trangThai == 3)
        {
            animator.SetBool("isBiNgoi3",false);
            animator.SetBool("isBiNgoi4",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -0.7 && batDauClick.x <= 0 && batDauClick.y >= 1 && hieu >= 1.8 && trangThai == 4)
        {
            animator.SetBool("isBiNgoi4",false);
            animator.SetBool("isBiNgoi5",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -1.5 && batDauClick.x <= -0.8 && batDauClick.y >= 1 && hieu >= 1.8 && trangThai == 5)
        {
            animator.SetBool("isBiNgoi5",false);
            animator.SetBool("isBiNgoi6",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -2.3 && batDauClick.x <= -1.8 && batDauClick.y >= 1 && hieu >= 1.8 && trangThai == 6)
        {
            animator.SetBool("isBiNgoi6",false);
            animator.SetBool("isBiNgoi7",true);
            hieu = 0;
            await Task.Delay(2000);
            isDone = true;
        }
    }
    private void OnMouseDown()
    {
        batDauClick=Vector2.zero;
        ketThucClick=Vector2.zero;  
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hieu = batDauClick.y - ketThucClick.y;
    }
}
