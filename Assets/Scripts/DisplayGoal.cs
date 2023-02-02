using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    [SerializeField] Toggle toggle;


    void Start()
    {
        toggle = GetComponent<Toggle>();
        markGoalComplete();
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
    }

    public void markGoalComplete()
    {
        if (toggle.isOn)
        {
            Debug.Log("toggle is on");
        }
        else if (!toggle.isOn)
        {
            Debug.Log("toggle is off");
        }
    }
}