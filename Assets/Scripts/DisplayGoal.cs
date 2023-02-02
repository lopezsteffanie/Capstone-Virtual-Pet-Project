using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayGoalText : MonoBehaviour
{
    // HappinessKeeper happinessKeeper;
    Gnome gnomeHappiness;
    public TextMeshProUGUI displayGoal;
    public TMP_InputField inputGoal;
    public GameObject inputField;

    void Start()
    {
        gnomeHappiness = FindObjectOfType<Gnome>();
    }

    public void setGoal()
    {
        gnomeHappiness.AddToHappiness();
        displayGoal.text = "Your goal: " + inputGoal.text;
        inputField.SetActive(false);
    }
}
