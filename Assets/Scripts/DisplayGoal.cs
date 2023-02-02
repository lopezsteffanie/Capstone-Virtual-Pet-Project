using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayGoal : MonoBehaviour
{
    Gnome gnomeHappiness;
    public TextMeshProUGUI displayGoal;
    public TMP_InputField inputGoal;
    public GameObject inputField;
    public GameObject toggleBox;
    public GameObject markCompleteText;
    public GameObject goalEnterButton;

    void Start()
    {
        gnomeHappiness = FindObjectOfType<Gnome>();
        toggleBox.SetActive(false);
        markCompleteText.SetActive(false);
    }

    public void setGoal()
    {
        gnomeHappiness.AddToHappiness();
        displayGoal.text = "Your goal: " + inputGoal.text;
        inputField.SetActive(false);
        goalEnterButton.SetActive(false);
        toggleBox.SetActive(true);
        markCompleteText.SetActive(true);
        inputGoal.text = "";
    }

    public void resetGoal()
    {
        displayGoal.text = "Your goal: ";
        inputField.SetActive(true);
        goalEnterButton.SetActive(true);
        toggleBox.SetActive(false);
        markCompleteText.SetActive(false);
    }
}