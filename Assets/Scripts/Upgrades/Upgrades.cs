using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : ScriptableObject
{
    public string upgradeName;
    public int upgradeLevel;
    public int upgradeCost;
    
    [Tooltip("By how much it increases the next upgrade cost")]
    public float multiplier;
}
