using UnityEngine;

public class SuiCao : MonoBehaviour
{
    [SerializeReference] private bool isClick = false;
    private SpriteRenderer spriteRenderer;
    [SerializeReference] private bool isNoiHapHap=false;
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
            if (isNoiHapHap&&NoiHap.trangThai==0)
            {
                Destroy(gameObject);
                NoiHap.trangThai++;
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
        if(other.tag == "NoiHap")
            isNoiHapHap = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "NoiHap")
            isNoiHapHap = false;
    }
}
