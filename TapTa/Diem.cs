using UnityEngine;

public class Diem : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(-6f, 6f), -3.2034f, 0);
    }
    
    void Update()
    {
        
    }
}
