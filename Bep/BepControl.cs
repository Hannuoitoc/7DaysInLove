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
        
    private bool isAudioMyTuongDen1=false;
    private bool isAudioMyTuongDen2=false;
    private bool isAudioSuiCao=false;
    private bool isAudioMyY1=false;
    private bool isAudioMyY2=false;
    private AudioSource audioSource;
    public AudioClip donedonedoen;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
                    if(batNuoc!=null)
                    batNuoc.SetActive(true);
                    if(vatMyTuongDen!=null)
                    vatMyTuongDen.SetActive(true);
                }

                if (Bat.trangThai == 1&&Bat.isClick==true)
                {
                    if (isAudioMyTuongDen1 == false)
                    {
                        isAudioMyTuongDen1=true;
                        audioSource.PlayOneShot(donedonedoen);
                    }
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
                    if(toi!=null)
                        toi.SetActive(true);
                        chao.SetActive(true);
                    if(bi!=null)
                        bi.SetActive(true);
                    if(diaThit!=null)
                        diaThit.SetActive(true);
                    if(khoaiTay!=null)
                        khoaiTay.SetActive(true);
                    if(hanhTay!=null)
                        hanhTay.SetActive(true);
                    if(duong!=null)
                        duong.SetActive(true);
                    if (tuongDen != null)
                        tuongDen.SetActive(true);
                }

                if (Bat.trangThai == 2 && Bat.isClick == true)
                {
                    if (isAudioMyTuongDen2 == false)
                        audioSource.PlayOneShot(donedonedoen);
                    isAudioMyTuongDen2=true;
                    if(isAudioMyTuongDen1==true)
                        GameControlMain.doneTuongDen=true;
                }
                break;
            case 3:
                SuiCao.SetActive(true);
                if (NoiHap.trangThai == 3 && NoiHap.isClick == true)
                {
                    if (isAudioSuiCao == false)
                        audioSource.PlayOneShot(donedonedoen);
                    isAudioSuiCao=true;
                    if(isAudioSuiCao==true)
                        GameControlMain.doneSuiCao = true;
                }
                break;
            case 6:
                if (Dia.trangThai == 0)
                {
                    noi.SetActive(true);
                    dia.SetActive(true);
                    if(batNuoc!=null)
                    batNuoc.SetActive(true);
                    if(vatMyY!=null)
                    vatMyY.SetActive(true);
                }

                if (Dia.trangThai == 1 && Dia.isClick == true)
                {
                    if (isAudioMyY1 == false)
                    {
                        isAudioMyY1=true;
                        audioSource.PlayOneShot(donedonedoen);
                    }
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
                    if(toi!=null)
                    toi.SetActive(true);
                    if(MyY!=null)
                    MyY.SetActive(true);
                }
                if (Dia.trangThai == 2 && Dia.isClick == true)
                {
                    if (isAudioMyY2 == false)
                        audioSource.PlayOneShot(donedonedoen);
                    isAudioMyY2=true;
                    if (isAudioMyY2 == true)
                    {
                        GameControlMain.instance.WaitAndDo(0.5f, () => {
                            GameControlMain.doneMyY=true;
                        });
                    }
                        
                }
                break;
        }

    }
}
