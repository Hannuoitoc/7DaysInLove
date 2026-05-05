using System.Threading.Tasks;
using UnityEngine;

public class CatBo : MonoBehaviour
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
        if (batDauClick.x >= 0.4 && batDauClick.x <= 0.7 && batDauClick.y >= 0 && hieu >= 2.5 && trangThai == 0)
        {
            animator.SetBool("isBo1",true);
            hieu = 0;
            trangThai++;
        }
        if (batDauClick.x >= 0.1 && batDauClick.x <= 0.4 && batDauClick.y >= 0 && hieu >= 2.5 && trangThai == 1)
        {
            animator.SetBool("isBo1",false);
            animator.SetBool("isBo2",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -0.3 && batDauClick.x <= 0.1 && batDauClick.y >= 0 && hieu >= 2.5 && trangThai == 2)
        {
            animator.SetBool("isBo2",false);
            animator.SetBool("isBo3",true);
            hieu = 0;
            trangThai++;
        }

        if (batDauClick.x >= -0.8 && batDauClick.x <= -0.3 && batDauClick.y >= 0 && hieu >= 2.5 && trangThai == 3)
        {
            animator.SetBool("isBo3",false);
            animator.SetBool("isBo4",true);
            hieu = 0;
            GameControlMain.instance.WaitAndDo(1f, () => {
                isDone=true;        
            });
            
        }
    }
    private void OnMouseDown()
    {
        hieu = 0;
        batDauClick=Vector2.zero;
        ketThucClick=Vector2.zero;  
        batDauClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
    }

    private void OnMouseUp()
    {
        ketThucClick = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hieu =  batDauClick.y - ketThucClick.y;
    }
}
