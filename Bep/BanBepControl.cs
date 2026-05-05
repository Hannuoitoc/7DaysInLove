using System.Threading.Tasks;
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
    public bool isAudioThit=false;
    public bool isAudioKhoaiTay=false;
    public bool isAudioBiNgoi=false;
    public bool isAudioHanhTay=false;
    private bool isAudioCaHoi=false;
    private bool isAudioBo=false;
    private bool isAudioManhTre=false;
    private bool isAudioShushi=false;
    private bool isAudioBanhMy=false;
    private bool isAudioSuiCao=false;
    private bool isAudioPizza=false;
    private AudioSource audioSource;
    public AudioClip correct;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameControlMain.Day)
        {
            case 1:
                Thot.SetActive(true);
                if(isAudioThit==false)
                Thit.SetActive(true);
                if (ThaiThit.isDone)
                {
                    if(isAudioThit==false)
                    audioSource.PlayOneShot(correct);
                    isAudioThit=true;
                    Thit.SetActive(false);
                    KhoaiTay.SetActive(true);
                    ThaiThit.isDone=false;
                }

                if (ThaiKhoaiTay.isDone)
                {
                    if(isAudioKhoaiTay==false)
                    audioSource.PlayOneShot(correct);
                    isAudioKhoaiTay=true;
                    BiNgoi.active = true;
                    KhoaiTay.active = false;
                    ThaiKhoaiTay.isDone = false;
                }

                if (ThaiBiNgoi.isDone)
                {
                    if(isAudioBiNgoi==false)
                    audioSource.PlayOneShot(correct);
                    isAudioBiNgoi=true;
                    HanhTay.active = true;
                    BiNgoi.active = false;
                    ThaiBiNgoi.isDone = false;
                }

                if (ThaiHanhTay.isDone)
                {
                    if(isAudioHanhTay==false)
                    audioSource.PlayOneShot(correct);
                    isAudioHanhTay=true;
                    ThaiHanhTay.isDone = false;
                    GameControlMain.instance.WaitAndDo(2f, () => {
                        SceneManager.LoadScene("Scenes/Bep");
                    });
                }
                break;
            case 2:
                banhMy.SetActive(true);
                if (BanhMy.trangThai == 8 && BanhMy.isClick == true)
                {
                    if (isAudioBanhMy == false)
                    {
                        isAudioBanhMy = true;
                        audioSource.PlayOneShot(correct);
                    }
                    GameControlMain.instance.WaitAndDo(2f, () => {
                        GameControlMain.doneBanhMy = true;
                    });
                }
                break;
            case 3:
                suiCao.SetActive(true);
                if (VoBanh.isClick == true && VoBanh.trangThai == 2)
                {
                    if (isAudioSuiCao == false) 
                        audioSource.PlayOneShot(correct);
                    isAudioSuiCao = true;
                    if(isAudioSuiCao==true)
                        SceneManager.LoadScene("Scenes/Bep");
                }
                break;
            case 4:
                pizza.SetActive(true);
                if (Pizza.donePizzSong==true)
                {
                    if (isAudioPizza == false)
                        audioSource.PlayOneShot(correct);
                    isAudioPizza = true;
                    GameControlMain.instance.WaitAndDo(1f, () => {
                        if(isAudioPizza==true)
                            SceneManager.LoadScene("Scenes/Lo");
                    });
                }
                break;
            case 5:
                if(ManhTre.isDone==false)
                Thot.SetActive(true);
                if(isAudioCaHoi==false)
                    CaHoi.SetActive(true);
                if (CatCaHoi.isDone)
                {
                    if(isAudioCaHoi==false)
                    audioSource.PlayOneShot(correct);
                    isAudioCaHoi=true;
                    CatCaHoi.isDone = false;
                    CaHoi.SetActive(false);
                    Bo.SetActive(true);
                }
                if (CatBo.isDone)
                {
                    if(isAudioBo==false)
                    audioSource.PlayOneShot(correct);
                    isAudioBo=true;
                    Bo.SetActive(false);
                    Thot.SetActive(false);
                    Shushi.SetActive(true);
                }

                if (ManhTre.isDone)
                {
                    if(isAudioManhTre==false)
                    audioSource.PlayOneShot(correct);
                    isAudioManhTre=true;
                    Shushi.SetActive(false);
                    Thot.SetActive(true);
                    ShushiCuon.SetActive(true);
                    isAudioBo=true;
                }

                if (ThaiShushi.isDone)
                {
                    if(isAudioShushi==false)
                    audioSource.PlayOneShot(correct);
                    isAudioShushi=true;
                    GameControlMain.instance.WaitAndDo(2f, () => {
                        GameControlMain.doneShushi = true;
                        ThaiShushi.isDone=false;
                    });
                }
                break;
        }
    }
}
