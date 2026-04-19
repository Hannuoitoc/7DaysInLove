using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Animator animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }
    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.linearVelocity = playerInput * speed;
        if (playerInput.x > 0||playerInput.x < 0)
        {
            playerInput.y = 0;
        }

        if (playerInput.y > 0 || playerInput.y < 0)
        {
            playerInput.x = 0;
        }
        
        if (playerInput.x > 0)
        {
            animator.SetBool("isRight", true);
        }
        else
        {
            animator.SetBool("isRight", false);
        }
        if (playerInput.x < 0)
        {
            animator.SetBool("isLeft", true);
        }
        else
        {
            animator.SetBool("isLeft", false);
        }
        if (playerInput.y > 0)
        {
            animator.SetBool("isUp", true);
        }
        else
        {
            animator.SetBool("isUp", false);
        }
        if (playerInput.y < 0)
        {
            animator.SetBool("isDown", true);
        }
        else
        {
            animator.SetBool("isDown", false);
        }
            
        
        
    }
    
}
