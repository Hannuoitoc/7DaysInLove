using System.Threading.Tasks;
using UnityEngine;

public class ThaiThit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
    void Update()
    {

        if (batDauClick.y >= 2 && hieu >= 3.6&&trangThai==0)
        {
            animator.SetBool("isThit2",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 1)
        {
            animator.SetBool("isThit2",false);
            animator.SetBool("isThit3",true);
            hieu = 0;
            trangThai++;
            GameControlMain.instance.WaitAndDo(0.5f, () => {
                 animator.SetBool("isThit3",false);
                animator.SetBool("isThit4",true);       
            });
        }
        if (batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 2)
        {
            animator.SetBool("isThit4",false);
            animator.SetBool("isThit5",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 3)
        {
            animator.SetBool("isThit5",false);
            animator.SetBool("isThit6",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 4)
        {
            animator.SetBool("isThit6",false);
            animator.SetBool("isThit7",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.y >= 2 && hieu >= 3.6 && trangThai == 5)
        {
            animator.SetBool("isThit7",false);
            animator.SetBool("isThit8",true);
            hieu = 0;
            trangThai++;
            GameControlMain.instance.WaitAndDo(1f, () => {
               isDone = true;         
            });
        }
        
    }
    private void OnMouseDown()
    {
        hieu = 0;
        batDauClick=Vector2.zero;
        ketThucClick=Vector2.zero;  
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hieu =  batDauClick.y - ketThucClick.y;
    }

}
