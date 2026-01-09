using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int coins = 0;
    public TMP_Text coinsCounter;

    public void AddCoins(int amount)
    {
        coins += amount;
        Debug.Log("Coins : " + coins);
        UpdateUI();
    }

    void UpdateUI()
    {
        coinsCounter.text = coins.ToString();
    }
}

