using System.Threading.Tasks;
using UnityEngine;

public class ThaiHanhTay : MonoBehaviour
{
    private Animator animator;
    private Vector2 batDauClick;
    private Vector2 ketThucClick;
    private int trangThai = 0;
    private float hieu = 0;
    private float hieuX = 0;
    public static bool isDone = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (batDauClick.y >= 0.1 && batDauClick.y <= 1.2 && batDauClick.x <= -1.5 && hieuX >= 2&&trangThai==0)
        {
            animator.SetBool("isHanhTay1",true);
            hieu = 0;
            hieuX = 0;
            trangThai++;
        }
        if (batDauClick.y >= -0.5 && batDauClick.y <= 0.1 && batDauClick.x <= -1.5 && hieuX >= 2&&trangThai==1)
        {
            animator.SetBool("isHanhTay1",false);
            animator.SetBool("isHanhTay2",true);
            hieu = 0;
            hieuX = 0;
            trangThai++;
        }
        if (batDauClick.y >= -1.4 && batDauClick.y <= -0.5 && batDauClick.x <= -1.5 && hieuX >= 2.8&&trangThai==2)
        {
            animator.SetBool("isHanhTay2",false);
            animator.SetBool("isHanhTay3",true);
            hieu = 0;
            hieuX = 0;
            trangThai++;
        }
        if (batDauClick.x >= -0.45 && batDauClick.x <= 0.1 && batDauClick.y >= 0 && hieu >= 2 && trangThai == 3)
        {
            animator.SetBool("isHanhTay3",false);
            animator.SetBool("isHanhTay4",true);
            hieu = 0;
            hieuX = 0;
            trangThai++;
        }

        if (batDauClick.x >= -1.1 && batDauClick.x <= -0.45 && batDauClick.y >= 0 && hieu >= 2 && trangThai == 4)
        {
            animator.SetBool("isHanhTay4",false);
            animator.SetBool("isHanhTay5",true);
            hieu = 0;
            hieuX = 0;
            trangThai++;
            GameControlMain.instance.WaitAndDo(1f, () => {
                isDone = true;        
            });
        }
    }
    private void OnMouseDown()
    {
        hieu = 0;
        hieuX = 0;
        batDauClick=Vector2.zero;
        ketThucClick=Vector2.zero;  
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hieu =  batDauClick.y - ketThucClick.y;
        hieuX = ketThucClick.x - batDauClick.x;
    }
}
