using UnityEngine;
using UnityEngine.SceneManagement;

public class BanBepControl : MonoBehaviour
{
    public GameObject Thot;
    public GameObject BiNgoi;
    public GameObject KhoaiTay;
    public GameObject HanhTay;
    public GameObject Thit;
    public GameObject banhMy;
    public GameObject suiCao;
    public GameObject pizza;
    public GameObject Shushi;
    public GameObject CaHoi;
    public GameObject Bo;
    public GameObject ShushiCuon;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameControlMain.Day)
        {
            case 1:
                Thot.SetActive(true);
                Thit.SetActive(true);
                if (ThaiThit.isDone)
                {
                    Thit.SetActive(false);
                    KhoaiTay.active = true;
                }

                if (ThaiKhoaiTay.isDone)
                {
                    BiNgoi.active = true;
                    KhoaiTay.active = false;
                }

                if (ThaiBiNgoi.isDone)
                {
                    BiNgoi.active = false;
                    HanhTay.active = true;
                }

                if (ThaiHanhTay.isDone)
                {
                    SceneManager.LoadScene("Scenes/Bep");
                }
                break;
            case 2:
                banhMy.SetActive(true);
                if (BanhMy.trangThai == 8 && BanhMy.isClick == true)
                {
                    GameControlMain.doneBanhMy = true;
                }
                break;
            case 3:
                suiCao.SetActive(true);
                if (VoBanh.isClick == true && VoBanh.trangThai == 2)
                {
                    SceneManager.LoadScene("Scenes/Bep");
                }
                break;
            case 4:
                pizza.SetActive(true);
                if (Pizza.donePizzSong==true)
                {
                    SceneManager.LoadScene("Scenes/Lo");
                }
                break;
            case 5:
                if(!CatBo.isDone)
                    Thot.SetActive(true);
                CaHoi.SetActive(true);
                if (CatCaHoi.isDone)
                {
                    CaHoi.SetActive(false);
                    Bo.SetActive(true);
                }
                if (CatBo.isDone)
                {
                    Bo.SetActive(false);
                    Thot.SetActive(false);
                    Shushi.SetActive(true);
                }

                if (ManhTre.isDone)
                {
                    Shushi.SetActive(false);
                    Thot.SetActive(true);
                    ShushiCuon.SetActive(true);
                }

                if (ThaiShushi.isDone)
                {
                    GameControlMain.doneShushi = true;
                }
                break;
        }
    }
}
