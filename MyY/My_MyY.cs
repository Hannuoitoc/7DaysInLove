using UnityEngine;

public class My_MyY : MonoBehaviour
{
    [SerializeReference] private bool isClick = false;
    private SpriteRenderer spriteRenderer;
    [SerializeReference] private bool isNoi=false;
    private Vector2 defaultPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        defaultPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClick && Noi.nuocSoi==true)
        {
            spriteRenderer.sortingOrder = 999;
            transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (!isClick)
        {
            if (isNoi&&Noi.trangThai==1)
            {
                Noi.trangThai=3;
                Destroy(gameObject);
            }
            else
            {
                transform.position=defaultPosition;
            }
        }
    }

    private void OnMouseDown()
    {
        isClick = true;
    }

    private void OnMouseUp()
    {
        isClick = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Noi")
            isNoi = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Noi")
            isNoi = false;
    }
}
