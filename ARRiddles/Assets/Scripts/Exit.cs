using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ExitMainPage);
    }

    void ExitMainPage()
    {
        SceneManager.LoadScene("Start");
    }
}
