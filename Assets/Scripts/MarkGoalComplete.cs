using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class MarkGoalComplete : MonoBehaviour
{
    public Toggle checkbox;
    public TextMeshProUGUI numGoalsCompleteText;
    int goalCount = 0;
    DisplayGoal displayGoal;
    Gnome gnomeHappiness;
    
    void Start()
    {
        displayGoal = FindObjectOfType<DisplayGoal>();
        gnomeHappiness = FindObjectOfType<Gnome>();       
    }

    public void checkifComplete()
    {
        if (checkbox.isOn)
        {
            gnomeHappiness.AddToHappiness();
            displayGoal.resetGoal();
            goalCount++;
            numGoalsCompleteText.text = "Number of goals completed: " + goalCount;
            checkbox.isOn = false;
        }
    }
}
