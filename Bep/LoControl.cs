using System.Threading.Tasks;
using UnityEngine;

public class LoControl : MonoBehaviour
{
    public static int trangThai = 0;
    public  GameObject pizzaSong;
    public GameObject pizzaChin;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    async Task Update()
    {
        switch (trangThai)
        {
            case 1:
                pizzaSong.SetActive(true);
                animator.SetBool("isLoMo", true);
                break;
            case 2:
                pizzaSong.SetActive(false);
                animator.SetBool("isLoMo", false);
                animator.SetBool("isLoDangNau", true);
                await Task.Delay(3000);
                animator.SetBool("isLoDangNau", false);
                animator.SetBool("isLoMo", true);
                pizzaChin.SetActive(true);
                trangThai=3;
                break;
        }
    }

    void OnMouseDown()
    {
        if(trangThai==0)
        trangThai = 1;
    }
    
}
