using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlMain : MonoBehaviour
{
    public static int Day = 1;
    [SerializeReference] public int DaySet;
    public static bool doneTuongDen=false;
    public static bool doneBanhMy=false;
    public static bool doneSuiCao=false;
    public static bool donePizza=false;
    public static bool doneShushi=false;
    public static bool doneMyY=false;
    public static GameControlMain instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Day=DaySet;
        if (doneTuongDen)
        {
            SceneManager.LoadScene("Scenes/Nha");
            DaySet = 2;
            doneTuongDen=false;
        }

        if (doneBanhMy)
        {
            SceneManager.LoadScene("Scenes/Nha");
            DaySet = 3;
            doneBanhMy=false;
        }

        if (doneSuiCao)
        {
            SceneManager.LoadScene("Scenes/Nha");
            DaySet = 4;
            doneSuiCao=false;
        }

        if (donePizza)
        {
            SceneManager.LoadScene("Scenes/Nha");
            DaySet = 5;
            donePizza=false;
        }

        if (doneShushi)
        {
            SceneManager.LoadScene("Scenes/Nha");
            DaySet = 6;
            doneShushi=false;
        }

        if (doneMyY)
        {
            SceneManager.LoadScene("Scenes/Nha");
            DaySet = 7;
            doneMyY=false;
        }
    }
}
