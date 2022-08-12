using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip crab, scorpian, snail, wolf, rabbit, swanGoose;
    Button btn_Play;
    AnimalType currType;
    Text text_animalName;

    private void Awake()
    {
        audioSource = GameObject.Find("Read").GetComponent<AudioSource>();
        btn_Play = audioSource.GetComponent<Button>();
        btn_Play.onClick.AddListener(PlayAudio);
        text_animalName = GameObject.Find("Name").GetComponent<Text>();
        currType = AnimalType.None;
        
    }

    public void PlayAudio()
    {
        if (!audioSource.isPlaying)
        {
            switch (currType)
            {
                case AnimalType.Crab:
                    audioSource.PlayOneShot(crab);
                    break;
                case AnimalType.Rabbit:
                    audioSource.PlayOneShot(rabbit);
                    break;
                case AnimalType.Scorpion:
                    audioSource.PlayOneShot(scorpian);
                    break;
                case AnimalType.Snail:
                    audioSource.PlayOneShot(snail);
                    break;
                case AnimalType.SwanGoose:
                    audioSource.PlayOneShot(swanGoose);
                    break;
                case AnimalType.Wolf:
                    audioSource.PlayOneShot(wolf);
                    break;
            }
        }
        
    }

    public void SetCurrType(AnimalType type)
    {
        currType = type;
    }

    public void SetAnimalNameText(AnimalType type)
    {
        if (type == AnimalType.SwanGoose)
        {
            text_animalName.text = "Swan Goose";
            return;
        }

        text_animalName.text = type.ToString();
        
    }

    public void SetAnimalNameTextToNone()
    {
        text_animalName.text = "";
    }
}
