using System;
using UnityEngine;

public class ThanhDo : MonoBehaviour
{
    public bool isDiem=false;
    public static bool isDiemClick=false;
    public float speed;
    public bool isDao=false;
    private AudioSource audioSource;
    public AudioClip audioClipCorrect;
    public AudioClip audioClipFail;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if(gameObject.transform.position.x>=7f&&isDao==false)
            isDao=true;
        if(gameObject.transform.position.x<=-7f&&isDao==true)
            isDao=false;
        if(isDao)
            transform.position = new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);
        if(!isDao)
            transform.position = new Vector2(transform.position.x+speed*Time.deltaTime, transform.position.y);
        if (isDiem == true && Input.GetKeyDown(KeyCode.Space))
        {
            TapTaControl.ScoreCode++;
            isDiemClick=true;
            audioSource.PlayOneShot(audioClipCorrect);
        }

        if (isDiem == false && Input.GetKeyDown(KeyCode.Space))
        {
            if(TapTaControl.ScoreCode>0)
                TapTaControl.ScoreCode--;
            audioSource.PlayOneShot(audioClipFail);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Diem")
        {
            isDiem=true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Diem")
        {
            isDiem=false;
        }
    }
}
