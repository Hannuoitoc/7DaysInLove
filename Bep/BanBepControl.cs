using UnityEngine;

public class BanBepControl : MonoBehaviour
{
    public GameObject BiNgoi;
    public GameObject KhoaiTay;
    public GameObject Thit;
    public GameObject Thot;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControlMain.Day == 1)
        {
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
            }
        }
    }
}
