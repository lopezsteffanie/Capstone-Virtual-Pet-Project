using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGnomeDisplay : MonoBehaviour
{

    [Header("Questions")]
    [SerializeField] AudioClip levelZeroSound;
    [SerializeField] AudioClip levelFiveSound;
    [SerializeField] AudioClip levelTenSound;
    [SerializeField] AudioClip levelFifteenSound;
    [SerializeField] AudioClip levelTwentySound;

    /////
    [SerializeField] Image gnomeImage;
    [SerializeField] GameObject gnome;

    HappinessKeeper happinessKeeper;

    void Start()
    {
        gnomeImage = gnome.GetComponent<Image>();
        happinessKeeper = FindObjectOfType<HappinessKeeper>();
    }

    void Update()
    {
        int happinessLevel = happinessKeeper.GetHappinessLevel();

        if (happinessLevel == 0)
        {
            gnomeImage.color = Color.black;
            GetComponent<AudioSource>().PlayOneShot(levelZeroSound);
        }
        else if (happinessLevel < 5)
        {
            gnomeImage.color = Color.red;
            GetComponent<AudioSource>().PlayOneShot(levelFiveSound);
        }
        else if (happinessLevel < 10)
        {
            gnomeImage.color = Color.yellow;
            GetComponent<AudioSource>().PlayOneShot(levelTenSound);
        }
        else if (happinessLevel < 15)
        {
            gnomeImage.color = Color.blue;
            GetComponent<AudioSource>().PlayOneShot(levelFifteenSound);
        }
        else
        {
            gnomeImage.color = Color.green;
            GetComponent<AudioSource>().PlayOneShot(levelTwentySound);
        }
    }
}
