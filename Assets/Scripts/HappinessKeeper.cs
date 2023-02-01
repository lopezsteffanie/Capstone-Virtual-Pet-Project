using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappinessKeeper : MonoBehaviour
{
    [Header("HappinessLevel")]
    int happinessLevel = 5;

    public int GetHappinessLevel()
    {
        return happinessLevel;
    }

    public void IncrementHappinessLevel()
    {
        happinessLevel++;
    }

    public void DecreaseHappinessLevel()
    {
        happinessLevel--;
    }
}
