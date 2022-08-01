using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum AnimalType
{
    Crab,
    Scorpian,
    Snail,
    SwanGoose,
    Wolf,
    Rabbit,
    Cover,
    None
}
public class ImageTarget : MonoBehaviour
{
    public AnimalType type;
    AudioManager audioManager;
    

    private void Awake()
    {
        audioManager = GameObject.Find("Read").GetComponent<AudioManager>();
        
    }

    public void SetType()
    {
        audioManager.SetCurrType(type);
        audioManager.SetAnimalNameText(type);
    }

    public void SetTypeToNone()
    {
        audioManager.SetCurrType(AnimalType.None);
        audioManager.SetAnimalNameTextToNone();
    }
}
