using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pawn : MonoBehaviour{
    public int Tier;
    
    public int oneAttack;
    
    public int count;

    public int costToBuy;
    public TextMeshProUGUI quantityText;
    public TextMeshProUGUI priceText;

    public gameObject buyButton;

    public void Update(){
        if(GameManager.instance.money < costToBuy){
            buyButton.SetActive(false);
        }
        else{
            buyButton.SetActive(true);
        }
    }
}
