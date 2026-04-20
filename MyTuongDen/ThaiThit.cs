using System.Threading.Tasks;
using UnityEngine;

public class Thit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    private int trangThai = 0;
    private float hieu = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    async Task Update()
    {
        if (batDauClick.x >= 0 && batDauClick.x <= 0.3 && batDauClick.y >= 2 && hieu >= 3.6&&trangThai==0)
        {
            animator.SetBool("isThit2",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -0.7 && batDauClick.x <= -0.5 && batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 1)
        {
            animator.SetBool("isThit2",false);
            animator.SetBool("isThit3",true);
            hieu = 0;
            trangThai++;
            await Task.Delay(500);
            animator.SetBool("isThit3",false);
            animator.SetBool("isThit4",true);
        }
        if (batDauClick.x >= 0.2 && batDauClick.x <= 0.8 && batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 2)
        {
            animator.SetBool("isThit4",false);
            animator.SetBool("isThit5",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= -0.2 && batDauClick.x <= 0.4 && batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 3)
        {
            animator.SetBool("isThit5",false);
            animator.SetBool("isThit6",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -0.6 && batDauClick.x <= -0.2 && batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 4)
        {
            animator.SetBool("isThit6",false);
            animator.SetBool("isThit7",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -1.4 && batDauClick.x <= -0.8 && batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 5)
        {
            animator.SetBool("isThit7",false);
            animator.SetBool("isThit8",true);
            hieu = 0;
            trangThai++;
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
