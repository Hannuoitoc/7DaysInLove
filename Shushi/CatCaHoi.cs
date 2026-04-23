using System.Threading.Tasks;
using UnityEngine;

public class CatCaHoi : MonoBehaviour
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
    async Task Update()
    {
        if (batDauClick.y >= 0 && batDauClick.y <= 0.8 && batDauClick.x <= -1.5 && hieu>= 2.8&&trangThai==0)
        {
            animator.SetBool("isCaHoi1",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.y >= -0.8 && batDauClick.y <= 0 && batDauClick.x <= -1.5 && hieu >= 2.8&&trangThai==1)
        {
            animator.SetBool("isCaHoi1",false);
            animator.SetBool("isCaHoi2",true);
            hieu = 0;
            await Task.Delay(1000);
            isDone=true;
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
        hieu = ketThucClick.x-batDauClick.x;
    }
}
