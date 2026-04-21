using UnityEngine;

public class Bo : MonoBehaviour
{
    [SerializeReference] private bool isClick = false;
    private SpriteRenderer spriteRenderer;
    [SerializeReference] private bool isManhTre=false;
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
        if (isClick)
        {
            spriteRenderer.sortingOrder = 999;
            transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (!isClick)
        {
            if (isManhTre&&ManhTre.trangThai==2)
            {
                Destroy(gameObject);
                ManhTre.trangThai++;
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
        if(other.tag == "ManhTre")
            isManhTre = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ManhTre")
            isManhTre = false;
    }
}
