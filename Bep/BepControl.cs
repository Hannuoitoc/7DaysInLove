using System.Threading.Tasks;
using UnityEngine;

public class BepControl : MonoBehaviour
{
    public GameObject noi;
    public GameObject chao;
    public GameObject dia;
    public GameObject vatMyY;
    public GameObject toi;
    public GameObject bat;
    public GameObject batNuoc;
    public GameObject vatMyTuongDen;
    public GameObject bi;
    public GameObject diaThit;
    public GameObject khoaiTay;
    public GameObject hanhTay;
    public GameObject duong;
    public GameObject tuongDen;
    public GameObject SuiCao;
    public GameObject MyY;
    void Start()
    {
        
    }

    void Update()
    {
        switch (GameControlMain.Day)
        {
            case 1:
                if (Bat.trangThai == 0)
                {
                    noi.SetActive(true);
                    bat.SetActive(true);
                    batNuoc.SetActive(true);
                    vatMyTuongDen.SetActive(true);
                }

                if (Bat.trangThai == 1&&Bat.isClick==true)
                {
                    if (Chao.trangThai == 13)
                    {
                        bat.SetActive(true);
                        Bat.isClick = false;
                    }
                    else
                    {
                        bat.SetActive(false);
                    }
                    noi.SetActive(false);
                    toi.SetActive(true);
                    chao.SetActive(true);
                    bi.SetActive(true);
                    diaThit.SetActive(true);
                    khoaiTay.SetActive(true);
                    hanhTay.SetActive(true);
                    duong.SetActive(true);
                    tuongDen.SetActive(true);
                    
                }

                if (Bat.trangThai == 2 && Bat.isClick == true)
                {
                    GameControlMain.doneTuongDen=true;
                }
                break;
            case 3:
                SuiCao.SetActive(true);
                if (NoiHap.trangThai == 3 && NoiHap.isClick == true)
                {
                    GameControlMain.doneSuiCao = true;
                }
                break;
            case 6:
                if (Dia.trangThai == 0)
                {
                    noi.SetActive(true);
                    dia.SetActive(true);
                    batNuoc.SetActive(true);
                    vatMyY.SetActive(true);
                }

                if (Dia.trangThai == 1 && Dia.isClick == true)
                {
                    if (Chao.trangThai == 5)
                    {
                        Dia.isClick = false;
                        dia.SetActive(true);
                    }
                    else
                    {
                        dia.SetActive(false);
                    }
                    chao.SetActive(true);
                    noi.SetActive(false);
                    toi.SetActive(true);
                    MyY.SetActive(true);
                }
                if (Dia.trangThai == 2 && Dia.isClick == true)
                {
                    GameControlMain.doneMyY=true;
                }
                break;
        }

    }
}
