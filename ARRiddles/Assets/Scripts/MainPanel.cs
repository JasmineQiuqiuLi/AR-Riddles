using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    Button btn_start;

    private void Awake()
    {
        btn_start = GameObject.Find("ButtonStart").GetComponent<Button>();
        btn_start.onClick.AddListener(StartAR);
    }

    void StartAR()
    {
        SceneManager.LoadScene("Main");
    }
}
