using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private TrailRenderer trail;
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        trail = GetComponent<TrailRenderer>();
        trail.emitting = false;
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = mousePos;
        
        if (Input.GetMouseButtonDown(0))
        {
            trail.Clear();
            trail.emitting = true;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            trail.emitting = false;
            audioSource.Play();
        }
    }
}
