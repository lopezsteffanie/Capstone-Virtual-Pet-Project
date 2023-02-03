using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gnome : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI happinessLevelText;
    HappinessKeeper happinessKeeper;

    [SerializeField] Slider happinessBar;

    [SerializeField] float delay = 60f;

    bool buttonClick;
    void Awake()
    {
        happinessKeeper = FindObjectOfType<HappinessKeeper>();
        happinessBar.maxValue = 20;
        happinessBar.value = 10;
    }

    void Start ()
    {
        StartCoroutine(DecreaseHappiness());
    }

    public void AddToHappiness()
    {
        happinessBar.value++;
        happinessKeeper.IncrementHappinessLevel();
        happinessLevelText.text = "Happiness level: " + happinessBar.value + "/" + happinessBar.maxValue;
    }

    public void onFeed()
    {
        AddToHappiness();
    }

    IEnumerator DecreaseHappiness()
    {
        while (happinessBar.value > 0)
        {
            yield return new WaitForSecondsRealtime(delay);
            happinessBar.value--;
            happinessKeeper.DecreaseHappinessLevel();
            happinessLevelText.text = "Happiness level: " + happinessBar.value + "/" + happinessBar.maxValue;
        }
    }
}