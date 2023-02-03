using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GnomeMoodChangeBehaviors : MonoBehaviour
{
    [Header("Gnome Colors")]
    [SerializeField] Sprite blueGnome;
    [SerializeField] Sprite redGnome;
    [SerializeField] Sprite greenGnome;
    [SerializeField] GameObject gnome;

    [Header("Gnome Sounds")]
    // [SerializeField] AudioClip happySound;
    // [SerializeField] AudioClip sadSound;
    // [SerializeField] AudioClip okSound;
    [SerializeField] AudioSource okAudio;
    [SerializeField] AudioSource happyAudio;
    [SerializeField] AudioSource sadAudio;
    [SerializeField] float countdown = 10f;

    HappinessKeeper happinessKeeper;

    void Start ()
    {
        happinessKeeper = FindObjectOfType<HappinessKeeper>();
        InvokeRepeating("PlaySound", 5f, 10f);
    }

    void Update ()
    {
        // Change gnome color
        Image gnomeImage;
        gnomeImage = gnome.GetComponent<Image>();

        int happinessLevel = happinessKeeper.GetHappinessLevel();

        if (happinessLevel < 7)
        {
            gnomeImage.sprite = redGnome;
        }
        else if (happinessLevel < 13)
        {
            gnomeImage.sprite = blueGnome;
        }
        else
        {
            gnomeImage.sprite = greenGnome;
        }
    }

    public void PlaySound()
    {
        int happinessLevel = happinessKeeper.GetHappinessLevel();

        if (happinessLevel < 7)
        {
            sadAudio.Play();
        }
        else if (happinessLevel < 13)
        {
            okAudio.Play();
        }
        else if (happinessLevel < 20)
        {
            happyAudio.Play();
        }
    }
}
