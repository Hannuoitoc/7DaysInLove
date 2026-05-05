using UnityEngine;

public class EndingControl : MonoBehaviour
{
    public GameObject Ending1;
    public GameObject Ending2;
    public GameObject Ending3;
    public GameObject Ending4;
    void Start()
    {
        if (GameControlMain.NauAn == 6)
        {
            if (GameControlMain.Gym == 6)
            {
                Ending4.SetActive(true);
            }
            else
            {
                Ending1.SetActive(true);
            }
        }
        else
        {
            if (GameControlMain.Gym == 6)
            {
                Ending3.SetActive(true);
            }
            else
            {
                Ending2.SetActive(true);
            }
        }
    }
    
    void Update()
    {
        
    }
}
