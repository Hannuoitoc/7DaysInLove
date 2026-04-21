using System;
using System.Threading.Tasks;
using UnityEngine;

public class Noi : MonoBehaviour
{
    public static int trangThai=0;
    public static bool nuocSoi=false;
    private bool myChin=false;
    private Animator animator;
    [SerializeReference] private bool isClick = false;
    private SpriteRenderer spriteRenderer;
    [SerializeReference] private bool isDia=false;
    private Vector2 defaultPosition;
    [SerializeReference]private bool isBat=false;
    void Start()
    {
        defaultPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    async Task Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isNoiNuoc", true);
                await Task.Delay(2000);
                animator.SetBool("isNoiNuoc", false);
                animator.SetBool("isNoiNuocSoi", true);
                nuocSoi=true;
                break;
            case 2:
                if (!myChin)
                {
                    animator.SetBool("isNoiNuocSoi", false);
                    animator.SetBool("isNoiMyY", true);
                    await Task.Delay(2000);
                    animator.SetBool("isNoiMyY", false);
                    animator.SetBool("isNoiMyToi", true);
                    await Task.Delay(2000);
                    animator.SetBool("isNoiMyToi", false);
                    animator.SetBool("isNoiMyChin", true);
                    myChin=true;
                }
                if (myChin)
                {
                    if (isClick)
                    {
                        spriteRenderer.sortingOrder = 999;
                        transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    }
                    else
                    {
                        if (isDia&&Dia.trangThai==0)
                        {
                            animator.SetBool("isNoiMyChin", false);
                            animator.SetBool("isNoi", true);
                            transform.position=defaultPosition;
                            Dia.trangThai++;
                        }
                        else
                        {
                            transform.position=defaultPosition;
                        }
                    }
                }
                break;
            case 3:
                if (!myChin)
                {
                    animator.SetBool("isNoiNuocSoi", false);
                    animator.SetBool("isNoiMyTuongDen", true);
                    await Task.Delay(2000);
                    animator.SetBool("isNoiMyTuongDen", false);
                    animator.SetBool("isNoiMyToi", true);
                    await Task.Delay(2000);
                    animator.SetBool("isNoiMyToi", false);
                    animator.SetBool("isNoiMyChin", true);
                }
                myChin=true;
                if (myChin)
                {
                    if (isClick)
                    {
                        spriteRenderer.sortingOrder = 999;
                        transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    }
                    else
                    {
                        if (isBat&&Bat.trangThai==0)
                        {
                            animator.SetBool("isNoiMyChin", false);
                            animator.SetBool("isNoi", true);
                            transform.position=defaultPosition;
                            Bat.trangThai++;
                        }
                        else
                        {
                            transform.position=defaultPosition;
                        }
                    }
                }
                break;

        }
    }
    private void OnMouseDown()
    {
        if((trangThai==2&&myChin)||(trangThai==3&&myChin))
            isClick = true;
    }

    private void OnMouseUp()
    {
        isClick = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Dia")
        {
            isDia = true;
        }

        if (other.tag == "Bat")
        {
            isBat=true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Dia")
        {
            isDia = false;
        }
        if (other.tag == "Bat")
        {
            isBat=false;
        }
    }
}
