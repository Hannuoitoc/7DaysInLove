using UnityEngine;

public class Bat : MonoBehaviour
{
    public static int trangThai=0;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (trangThai)
        {
            case 1:
                animator.SetBool("isBatMy", true);
                break;
            case 2:
                animator.SetBool("isBatMy", false);
                animator.SetBool("isBatMyTuongDen", true);
                break;
        }
    }
}
