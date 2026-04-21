using UnityEngine;

public class Dia : MonoBehaviour
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
                animator.SetBool("isDiaMy", true);
                break;
            case 2:
                animator.SetBool("isDiaMy", false);
                animator.SetBool("isDiaMyY", true);
                break;
        }
    }
}
