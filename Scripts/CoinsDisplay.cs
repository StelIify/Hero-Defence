using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsDisplay : MonoBehaviour
{
    [SerializeField] int coins = 50;
    Text coinsText;
    void Start()
    {
        coinsText = GetComponent<Text>();
        UpdateDisplay();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateDisplay()
    {
        coinsText.text = coins.ToString();
    }

    public bool HaveEnoughCoins(int amount)
    {
        if (coins >= amount)
            return true;
        else
            return false;
    }
    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateDisplay();
    }
    public void SpendCoins(int amount)
    {
        if( coins >= amount)
        {
            coins -= amount;
            UpdateDisplay();
        }
       
    }
}
