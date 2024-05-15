using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClickManager : MonoBehaviour
{
    public Pawn[] pawnPrefabs; 
    public List<float> autoClicker = new List<float>();
    public int autoClickerPrice;
    public TextMeshProUGUI quantityText;
    public TextMeshProUGUI priceText;

    private void Update()
    {
        // Loop through each auto clicker
        for (int i = 0; i < autoClicker.Count; i++)
        {
            // Is it time to click?
            if(Time.time - autoClicker[i] >= 1.0f)
            {
                autoClicker[i] = Time.time;
                MonsterManager.instance.curMonster.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        if(GameManager.instance.money >= autoClickerPrice)
        {
            GameManager.instance.TakeMoney(autoClickerPrice);
            autoClickerPrice = (int)((double) autoClickerPrice * 1.5);
            autoClicker.Add(Time.time);

            quantityText.text = "x" + autoClicker.Count.ToString();
            priceText.text = "$" + autoClickerPrice.ToString();
        }
    }
}
