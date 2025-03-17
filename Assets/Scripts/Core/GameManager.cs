using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [Header("References")]
    public Clicker clicker;

    [Header("Currency")] 
    public int currencyAmount;
    
    [Header("Temp Header")]
    public TextMeshProUGUI currencyText;

    public event Action CurrencyIncreased;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
        CurrencyIncreased?.Invoke();
        UpdateUI();
    }

    private void OnEnable()
    {
        clicker.OnClickEvent += OnClickInvoked;
    }

    private void OnDisable()
    {
        clicker.OnClickEvent -= OnClickInvoked;
    }

    private void OnClickInvoked()
    {
        IncreaseCurrency();
    }

    private void IncreaseCurrency()
    {
        currencyAmount += 1;
        UpdateUI();
        CurrencyIncreased?.Invoke();
    }

    private void UpdateUI()
    {
        if (currencyText != null) currencyText.text = currencyAmount.ToString();
    }
}
