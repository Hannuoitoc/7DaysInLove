using System;
using UnityEngine;
using UnityEngine.UI;

public class NaoImage : MonoBehaviour
{
    public GameObject ChatTable;
    public static bool isChat;
    void Start()
    {
    }
    void Update()
    {
        isChat = ChatTable.activeSelf;
        // if (Input.GetKeyDown(KeyCode.Tab))
        // {
        //     ChatTable.SetActive(!ChatTable.activeSelf);
        // }
    }
}
