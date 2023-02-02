using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayGoalText : MonoBehaviour
{
    public TextMeshProUGUI displayGoal;
    public TMP_InputField inputGoal;

    public void setGoal()
    {
        displayGoal.text = "Your goal: " + inputGoal.text;
    }
}
