using UnityEngine;

public class Hanh : MonoBehaviour
{
    [SerializeReference]private bool isThitBam=false;
    [SerializeReference]private bool isClick=false;
    private SpriteRenderer spriteRenderer;
    private Vector2 defaultPosition;
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        defaultPosition=transform.position;
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
            if (isThitBam&&ThitBam.trangThai==0)
            {
                ThitBam.trangThai++;
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
        isClick=true;
    }

    private void OnMouseUp()
    {
        isClick=false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ThitBam")
        {
            isThitBam=true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ThitBam")
        {
            isThitBam=false;
        }
    }
}
