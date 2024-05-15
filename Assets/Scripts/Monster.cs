using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour{
    public int curHp;
    
    public int MaxHp;

    public int moneyToGive;

    public Image healthBarFill;

    public void Damage()
    {
        curHp--;
        healthBarFill.fillAmount = (float) curHp / (float) MaxHp;

        if(curHp <= 0)
        {
            Caught();
        }
    }

    public void Caught()
    {
        GameManager.instance.AddMoney(moneyToGive);
        MonsterManager.instance.ReplaceMonster(gameObject);
    }
}
