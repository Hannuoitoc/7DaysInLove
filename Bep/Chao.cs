using UnityEngine;

public class Chao : MonoBehaviour
{
    private AudioSource  audioSource;
    public static int trangThai=0;
    private Animator animator;
    [SerializeReference] private bool isClick = false;
    private SpriteRenderer spriteRenderer;
    [SerializeReference] private bool isDia=false;
    [SerializeReference] private bool isBat=false;
    private Vector2 defaultPosition;
    void Start()
    {
        defaultPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        audioSource =  GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isChaoToi", true);
                break;
            case 2:
                animator.SetBool("isChaoToi", false);
                animator.SetBool("isChaoToiPhi", true);
                if(!audioSource.isPlaying)
                    audioSource.Play();
                break;
            case 3:
                animator.SetBool("isChaoToiPhi", false);
                animator.SetBool("isChaoCaChua", true);
                break;
            case 4:
                animator.SetBool("isChaoCaChua", false);
                animator.SetBool("isChaoCaChuaThitBam", true);
                break;
            case 5: 
                animator.SetBool("isChaoCaChuaThitBam", false);
                animator.SetBool("isChaoCaChuaThitBamXao", true);
                if (isClick)
                {
                    spriteRenderer.sortingOrder = 999;
                    transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
                else
                {
                    if (isDia&&Dia.trangThai==1)
                    {
                        animator.SetBool("isChaoCaChuaThitBamXao", false);
                        animator.SetBool("isChao", true);
                        transform.position=defaultPosition;
                        audioSource.Stop();
                        Dia.trangThai++;
                    }
                    else
                    {
                        transform.position=defaultPosition;
                    }
                }
                break;
            case 6:
                animator.SetBool("isChaoToiPhi", false);
                animator.SetBool("isChaoThit", true);
                break;
            case 7:
                animator.SetBool("isChaoThit", false);
                animator.SetBool("isChaoThitKhoaiTay", true);
                break;
            case 8:
                animator.SetBool("isChaoThitKhoaiTay", false);
                animator.SetBool("isChaoThitKhoaiTayBi", true);
                break;
            case 9:
                animator.SetBool("isChaoThitKhoaiTayBi", false);
                animator.SetBool("isChaoThitKhoaiTayBiHanh", true);
                break;
            case 10:
                animator.SetBool("isChaoThitKhoaiTayBiHanh", false);
                animator.SetBool("isChaoHonHopRauCuXao", true);
                break;
            case 11:
                animator.SetBool("isChaoHonHopRauCuXao", false);
                animator.SetBool("isChaoRauCuTuongDen", true);
                break;
            case 12:
                animator.SetBool("isChaoRauCuTuongDen", false);
                animator.SetBool("isChaoRauCuTuongDenDuong", true);
                break;
            case 13:
                animator.SetBool("isChaoRauCuTuongDenDuong", false);
                animator.SetBool("isChaoRauCuTuongDen", true);
                if (isClick)
                {
                    spriteRenderer.sortingOrder = 999;
                    transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
                else
                {
                    if (isBat&&Bat.trangThai==1)
                    {
                        animator.SetBool("isChaoRauCuTuongDen", false);
                        animator.SetBool("isChao", true);
                        transform.position=defaultPosition;
                        audioSource.Stop();
                        Bat.trangThai++;
                    }
                    else
                    {
                        transform.position=defaultPosition;
                    }
                }
                break;
        }
    }
    private void OnMouseDown()
    {
        if(trangThai==5||trangThai==13)
            isClick = true;
        if(trangThai==1||trangThai==4||trangThai==9||trangThai==12)
            trangThai ++;
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
        if(other.tag=="Bat")
        {
            isBat = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Dia")
        {
            isDia = false;
        }
        if(other.tag=="Bat")
        {
            isBat = false;
        }
    }
}
