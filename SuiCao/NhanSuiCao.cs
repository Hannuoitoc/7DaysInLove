using System;
using UnityEngine;

public class NhanSuiCao : MonoBehaviour
{
    private bool isVoBanh=false;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ThitBam.isClick)
        {
            spriteRenderer.sortingOrder = 999;
            transform.position=(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else
        {
            spriteRenderer.sortingOrder = -1;
            if (isVoBanh)
            {
                VoBanh.trangThai++;
                Destroy(gameObject);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="VoBanhSuiCao")
        {
            isVoBanh=true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "VoBanhSuiCao")
        {
            isVoBanh=false;
        }
    }
}
