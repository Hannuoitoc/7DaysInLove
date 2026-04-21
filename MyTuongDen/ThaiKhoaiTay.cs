using System.Threading.Tasks;
using UnityEngine;

public class ThaiKhoaiTay : MonoBehaviour
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

        if (batDauClick.y >= 0 && batDauClick.y <= 0.7 && batDauClick.x <= -1.4 && ketThucClick.x-batDauClick.x >= 2.7&&trangThai==0)
        {
            animator.SetBool("isKhoaiTay1",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.y >= -0.7 && batDauClick.y <= 0 && batDauClick.x <= -1.4 && ketThucClick.x-batDauClick.x >= 2.7&&trangThai==1)
        {
            animator.SetBool("isKhoaiTay1",false);
            animator.SetBool("isKhoaiTay2",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -0.1 && batDauClick.x <= 0.8 && batDauClick.y >= 1 && hieu >= 2 && trangThai == 2)
        {
            animator.SetBool("isKhoaiTay2",false);
            animator.SetBool("isKhoaiTay3",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -0.9 && batDauClick.x <= -0.1 && batDauClick.y >= 1 && hieu >= 2 && trangThai == 3)
        {
            animator.SetBool("isKhoaiTay3",false);
            animator.SetBool("isKhoaiTay4",true);
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
