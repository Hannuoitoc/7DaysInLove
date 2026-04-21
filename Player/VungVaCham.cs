using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VungVaCham : MonoBehaviour
{
    [SerializeField] private int vaCham = 0;
    private bool isClickE = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckE();
        if (isClickE)
        {
            if (vaCham != 0)
            {
                switch (vaCham)
                {
                    case 1:
                        SceneManager.LoadScene("Scenes/BanBep");
                        break;
                    case 2:
                        SceneManager.LoadScene("Scenes/Bep");
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
    }

    private void CheckE()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isClickE = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            isClickE = false;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "BanBep")
        {
            vaCham=1;
        }

        if (other.tag == "Bep")
        {
            vaCham=2;
        }

        if (other.tag == "BanDeTa")
        {
            vaCham=3;
        }

        if (other.tag == "Loa")
        {
            vaCham=4;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "BanBep")
        {
            vaCham=0;
        }

        if (other.tag == "Bep")
        {
            vaCham=0;
        }

        if (other.tag == "BanDeTa")
        {
            vaCham=0;
        }

        if (other.tag == "Loa")
        {
            vaCham=0;
        }
    }
}
