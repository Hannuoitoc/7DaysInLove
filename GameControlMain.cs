using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlMain : MonoBehaviour
{
    public int ngayNauAn;
    public int ngayTapGym;
    public GameObject Nu9;
    public GameObject canvas;
    public GameObject player;
    public static int Day = 1;
    public static int Gym = 0;
    public static int NauAn = 0;
    public static bool isGymToday=false;
    public static int ngonNgu = 2;
    public int DaySet;
    public static bool doneTuongDen=false;
    public static bool doneBanhMy=false;
    public static bool doneSuiCao=false;
    public static bool donePizza=false;
    public static bool doneShushi=false;
    public static bool doneMyY=false;
    public static bool isDoneXemTivi=false;
    public static GameControlMain instance;
    public TextMeshProUGUI Ngay;
    public GameObject NgayGameObject;
    public GameObject PauseGame;
    
    private bool isAudioMyTuongDen=false;
    private bool isAudioBanhMy=false;
    private bool isAudioSuiCao=false;
    private bool isAudioPizza=false;
    private bool isAudioShushi=false;
    private bool isAudioMyY=false;

    public GameObject CotChuyenMoDau;
    private bool isCotChuyenMoDau=false;
    
    public GameObject CotChuyenMyTuongDen;
    public GameObject CotChuyenBanhMy;
    public GameObject CotChuyenSuiCao;
    public GameObject CotChuyenPizza;
    public GameObject CotChuyenShushi;
    public GameObject CotChuyenMyY;

    public TextMeshProUGUI textGym;
    public  TextMeshProUGUI textNuChinh;
    public TextMeshProUGUI textNgay7;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(canvas);
        }
        else
        {
            Destroy(gameObject);
            Destroy(canvas);
        }
    }
    private AudioSource audioSource;
    public AudioClip donedonedone;
    public AudioClip coccoccoc;
    private bool isCocAudio=false;
    public AudioClip endingMusic;
    private bool isEndingMusic=false;
    void Start()
    {
        CotChuyenMoDau.SetActive(true);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        ngayNauAn = NauAn;
        ngayTapGym = Gym;
        if (ngonNgu == 1)
        {
            textGym.SetText("Hôm nay tôi đã tập gym rồi.");
            textNuChinh.SetText("Có lẽ mình nên giúp cô ấy nấu ăn để cảm ơn vì đã cho mình ở nhờ.");
            textNgay7.SetText("Tôi nên ra mở cửa cho cô ấy.");
        }
        else
        {
            textGym.SetText("I went to the gym today.");
            textNuChinh.SetText("Maybe I should help her cook to thank her for letting me stay with her.");
            textNgay7.SetText("I should go open the door for her.");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (VungVaCham.isThongBao)
            {
                PauseGame.SetActive(!PauseGame.activeSelf);
            }
            else
            {
                if (Time.timeScale == 0f)
                {
                    PauseGame.SetActive(false);
                    Time.timeScale = 1f;
                }
                else
                {
                    PauseGame.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
        }
        if (isCotChuyenMoDau == true&&SceneManager.GetActiveScene().name=="Nha")
        {
            NgayGameObject.SetActive(true);
        }
        if (NgayGameObject.activeSelf==true&&SceneManager.GetActiveScene().name=="Nha")
        {
            NgayGameObject.SetActive(true);
            Ngay.SetText("DAY "+Day);
        }
        else
        {
            NgayGameObject.SetActive(false);
        }
        if (TapTaControl.isGymToday)
        {
            TapTaControl.isGymToday=false;
            if (player == null)
            {
                player = GameObject.Find("Player"); 
            }
            player.transform.position = VungVaCham.posPlayer;
        }
        if (MoDau.isCotChuyenMoDau&&!isCotChuyenMoDau)
        { 
            isCotChuyenMoDau=true;
            CotChuyenMoDau.SetActive(false);
        }
        if (SceneManager.GetActiveScene().name == "TapTa")
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();
        }
        Day=DaySet;
        if (isDoneXemTivi)
        {
            isDoneXemTivi=false;
            DaySet++;
        }
        if (doneTuongDen)
        {
            CotChuyenMyTuongDen.SetActive(true);
            if (isAudioMyTuongDen == false)
            {
                isAudioMyTuongDen=true;
                NauAn++;
                audioSource.PlayOneShot(donedonedone);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/Nha");
                WaitAndDo(1f, () =>
                {
                    CotChuyenMyTuongDen.SetActive(false);
                                    doneTuongDen=false;
                                    
                                    isGymToday=false;
                                    DaySet = 2;
                                    Noi.trangThai = 0;
                                    Chao.trangThai = 0;
                                    Noi.nuocSoi=false;
                });
                
            }
        }

        if (doneBanhMy)
        {
            CotChuyenBanhMy.SetActive(true);
            if (isAudioBanhMy == false)
            {
                isAudioBanhMy=true;
                NauAn++;
                audioSource.PlayOneShot(donedonedone);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/Nha");
                WaitAndDo(1f, () =>
                {
                    CotChuyenBanhMy.SetActive(false);
                                    doneBanhMy=false;
                                    isGymToday=false;  
                                    DaySet = 3;
                });
                
            }
        }

        if (doneSuiCao)
        {
            CotChuyenSuiCao.SetActive(true);
            if (isAudioSuiCao == false)
            {
                isAudioSuiCao = true;
                NauAn++;
                audioSource.PlayOneShot(donedonedone);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/Nha");
                WaitAndDo(1f, () =>
                {
                    CotChuyenSuiCao.SetActive(false);
                                    doneSuiCao=false;
                                    isGymToday=false;  
                                    DaySet = 4;
                });
                
            }
        }

        if (donePizza)
        {
            CotChuyenPizza.SetActive(true);
            
            if (isAudioPizza == false)
            {
                isAudioPizza=true;
                NauAn++;
                audioSource.PlayOneShot(donedonedone);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/Nha");
                WaitAndDo(1f, () =>
                {
                    CotChuyenPizza.SetActive(false);
                    donePizza=false;
                    isGymToday=false;  
                    DaySet = 5;
                });
                
            }
        }

        if (doneShushi)
        {
            CotChuyenShushi.SetActive(true);
            
            if (isAudioShushi == false)
            {
                isAudioShushi=true;
                NauAn++;
                audioSource.PlayOneShot(donedonedone);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/Nha");
                WaitAndDo(1f, () =>
                {
                    CotChuyenShushi.SetActive(false);
                    doneShushi=false;
                    isGymToday=false;  
                    DaySet = 6;
                });
                
            }
        }

        if (doneMyY)
        {
            CotChuyenMyY.SetActive(true);
            if (isAudioMyY == false)
            {
                isAudioMyY=true;
                NauAn++;
                audioSource.PlayOneShot(donedonedone);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Scenes/Nha");
                WaitAndDo(1f, () =>
                {
                    CotChuyenMyY.SetActive(false);
                    doneMyY=false;
                    isGymToday=false;  
                    DaySet = 7;
                });
            }
        }
        if (DaySet == 7)
        {
            if (SceneManager.GetActiveScene().name == "Nha")
            {
                if (Nu9 == null)
                {
                    Nu9 = GameObject.Find("NuChinh"); 
                }
                Nu9.SetActive(false);
                if (isCocAudio == false)
                {
                    isCocAudio=true;
                    audioSource.clip = coccoccoc;
                    audioSource.Play();
                }
            }
            else
            {
                if (isCocAudio == true)
                {
                    isCocAudio=false;
                    audioSource.clip = endingMusic;
                    audioSource.Play();
                }
            }
        }
    }

    public IEnumerator Wait(float  time)
    {
        yield return new WaitForSeconds(time);
    }
    public void WaitAndDo(float seconds, System.Action action)
    {
        StartCoroutine(Execute(seconds, action));
    }

    private IEnumerator Execute(float seconds, System.Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
