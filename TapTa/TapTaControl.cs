using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapTaControl : MonoBehaviour
{
    public static bool isGymToday=false;
    public TextMeshProUGUI textScore;
    public GameObject TapTa;
    public GameObject HitDat;
    public Animator TapTaAnim;
    public Animator HitDatAnim;
    public GameObject Diem;
    private GameObject currentDiemClone;
    public int Score;
    public int PassScore;
    public static int ScoreCode;
    void Start()
    {
        currentDiemClone=Instantiate(Diem, transform.position, transform.rotation);
    }

    void Update()
    {
        textScore.text = Score.ToString()+"/"+PassScore.ToString();
        Score = ScoreCode;
        if (Score <= PassScore/2)
        {
            HitDat.SetActive(true);
            TapTa.SetActive(false);
        }
        else
        {
            HitDat.SetActive(false);
            TapTa.SetActive(true);
        }
        if (ThanhDo.isDiemClick == true)
        {
            if (ScoreCode > PassScore)
            {
                GameControlMain.Gym++;
                GameControlMain.isGymToday=true;
                isGymToday=true;
                SceneManager.LoadScene("Scenes/Nha");
            }
            else
            {
                if (ScoreCode <= PassScore / 2)
                {
                    HitDatAnim.SetBool("isHitDat", true);
                    HitDatAnim.SetBool("isHitDat1", false);
                    GameControlMain.instance.WaitAndDo(0.2f, () => {
                        HitDatAnim.SetBool("isHitDat", false);
                        HitDatAnim.SetBool("isHitDat1", true);
                    });
                }
                else
                {
                    TapTaAnim.SetBool("isTapTa", true);
                    TapTaAnim.SetBool("isTapTa1", false);
                    GameControlMain.instance.WaitAndDo(0.2f, () => {
                        TapTaAnim.SetBool("isTapTa", false);
                        TapTaAnim.SetBool("isTapTa1", true);
                    });
                    
                }
                ThanhDo.isDiemClick = false;
                if (currentDiemClone != null)
                {
                    Destroy(currentDiemClone); 
                }
                currentDiemClone = Instantiate(Diem, transform.position, transform.rotation);
            }
        }
    }
}
