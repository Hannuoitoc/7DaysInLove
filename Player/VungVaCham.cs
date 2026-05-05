using System;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VungVaCham : MonoBehaviour
{
    [SerializeField] private int vaCham = 0;
    public GameObject player;
    public static Vector2 posPlayer;
    public GameObject thongBaoGym;
    public GameObject thongBaoNuChinh;
    public GameObject xemTiVi;
    public bool isDoneXemTivi=false;
    public GameObject thongBaoNgay7;
    public GameObject Canvas;
    public static bool isThongBao=false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("Player");
        }
        if (Canvas == null)
        {
            Canvas=GameObject.Find("Canvas");
        }
        else
        {
            thongBaoGym=Canvas.transform.Find("ThongBaoGym").gameObject;
            thongBaoNuChinh = Canvas.transform.Find("ThongBaoNuChinh").gameObject;
            thongBaoNgay7=Canvas.transform.Find("ThongBaoNgay7").gameObject;
            xemTiVi=Canvas.transform.Find("XemTiVi").gameObject;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (vaCham != 0)
            {
                switch (vaCham)
                {
                    case 1:
                        if (GameControlMain.Day==7)
                        {
                            if (Time.timeScale == 0f)
                            {
                                isThongBao=false;
                                thongBaoNgay7.SetActive(false);
                                Time.timeScale = 1f;
                            }
                            else
                            {
                                isThongBao=true;
                                thongBaoNgay7.SetActive(true);
                                Time.timeScale = 0f;
                            }
                        }
                        else
                        {
                            if(GameControlMain.Day==6)
                                SceneManager.LoadScene("Scenes/Bep");
                            else
                                SceneManager.LoadScene("Scenes/BanBep");
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        if (GameControlMain.Day==7)
                        {
                            if (Time.timeScale == 0f)
                            {
                                isThongBao=false;
                                thongBaoNgay7.SetActive(false);
                                Time.timeScale = 1f;
                            }
                            else
                            {
                                isThongBao=true;
                                thongBaoNgay7.SetActive(true);
                                Time.timeScale = 0f;
                            }
                        }
                        else
                        {
                            if(GameControlMain.isGymToday==false)
                            {
                                posPlayer = player.transform.position;
                                TapTaControl.ScoreCode = 0;
                                SceneManager.LoadScene("Scenes/TapTa");
                            }
                            else
                            {
                                if (Time.timeScale == 0f)
                                {
                                    isThongBao=false;
                                    thongBaoGym.SetActive(false);
                                    Time.timeScale = 1f;
                                }
                                else
                                {
                                    isThongBao=true;
                                    thongBaoGym.SetActive(true);
                                    Time.timeScale = 0f;
                                }
                            }
                        }
                        break;
                    case 4:
                        if (GameControlMain.Day == 7)
                        {
                            if (Time.timeScale == 0f)
                            {
                                isThongBao=false;
                                thongBaoNgay7.SetActive(false);
                                Time.timeScale = 1f;
                            }
                            else
                            {
                                isThongBao = true;
                                thongBaoNgay7.SetActive(true);
                                Time.timeScale = 0f;
                            }
                        }
                        else
                        {
                            xemTiVi.SetActive(true);
                            isDoneXemTivi=true;
                            GameControlMain.instance.WaitAndDo(2f, () => {
                                if (isDoneXemTivi == true)
                                {
                                    isDoneXemTivi=false;
                                    xemTiVi.SetActive(false);
                                    GameControlMain.isDoneXemTivi=true;
                                }
                            });
                        }
                        break;
                    case 5:
                        if (GameControlMain.Day == 7)
                        {
                            if (Time.timeScale == 0f)
                            {
                                isThongBao=false;
                                thongBaoNgay7.SetActive(false);
                                Time.timeScale = 1f;
                            }
                            else
                            {
                                isThongBao=true;
                                thongBaoNgay7.SetActive(true);
                                Time.timeScale = 0f;
                            }
                        }
                        else
                        {
                            if (Time.timeScale == 0f)
                            {
                                isThongBao=false;
                                thongBaoNuChinh.SetActive(false);
                                Time.timeScale = 1f;
                            }
                            else
                            {
                                isThongBao = true;
                                thongBaoNuChinh.SetActive(true);
                                Time.timeScale = 0f;
                            }
                        }
                        break;
                    case 6:
                        if (GameControlMain.Day == 7)
                        {
                            SceneManager.LoadScene("Scenes/Ending");
                        }
                        break;
                }
            }
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

        if (other.tag == "GheSofa")
        {
            vaCham=4;
        }
        if (other.tag == "NuChinh")
        {
            vaCham=5;
        }

        if (other.tag == "Cua")
        {
            vaCham=6;
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

        if (other.tag == "GheSofa")
        {
            vaCham=0;
        }
        if (other.tag == "NuChinh")
        {
            vaCham=0;
        }
        if (other.tag == "Cua")
        {
            vaCham=0;
        }
    }
}
