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

    [SerializeField] float delay = 3f;

    bool buttonClick = false;

    void Awake()
    {
        happinessKeeper = FindObjectOfType<HappinessKeeper>();
        happinessBar.maxValue = 10;
        happinessBar.value = 5;
    }

    void Start ()
    {
        while (!buttonClick && happinessBar.value > 0)
        {
            StartCoroutine(DecreaseHappiness());
        }
    }

    public void OnFeedSelect()
    {
        buttonClick =true;
        happinessBar.value++;
        happinessKeeper.IncrementHappinessLevel();
        happinessLevelText.text = "Happiness level: " + happinessBar.value + "/" + happinessBar.maxValue;
    }

    IEnumerator DecreaseHappiness()
    {
        yield return new WaitForSeconds(delay);
        happinessBar.value--;
        happinessKeeper.DecreaseHappinessLevel();
        happinessLevelText.text = "Happiness level: " + happinessBar.value + "/" + happinessBar.maxValue;
    }
}