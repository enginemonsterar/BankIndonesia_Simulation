using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class MoneySupplyManager : Singleton<MoneySupplyManager>
{
    [Header("Main")]
    private float moneySupply;    
    private float targetMoney = 0;
    private int divider = 75;

    private bool isAddSuply;
    

    [Header("UI")]
    [SerializeField] private Slider moneySupplySlider;
    
    void Start(){
        
    }

    void Update(){
        
        if (isAddSuply)
        {        
            if(moneySupply < targetMoney){
                moneySupply += 0.3f * Time.deltaTime;
                moneySupplySlider.value = moneySupply;            
            } else if(moneySupply > targetMoney)
            {
                moneySupply = targetMoney;
                moneySupplySlider.value = moneySupply;
            }

        }else {
            
            if(targetMoney < moneySupply){
                moneySupply -= 0.3f * Time.deltaTime;
                moneySupplySlider.value = moneySupply;            
            } else if(moneySupply < targetMoney)
            {
                moneySupply = targetMoney;
                moneySupplySlider.value = moneySupply;
            }
        }
        
    }

    void MakeItStable(){
        Debug.Log("Make it Stable");
        moneySupply = targetMoney;
        moneySupplySlider.value = moneySupply;
    }
        
    
    public void AddSupply(float value){    
        isAddSuply = true;
            
        targetMoney += value / divider;
        // targetMoney += moneySupply;

        if(targetMoney > 1)
            targetMoney = 1;

        Debug.Log("Target Money: " + targetMoney);

        Invoke("MakeItStable",5);
        
    }

    public void SubstractSupply(float value){
        isAddSuply = false;
        targetMoney -= value / divider;
        // targetMoney -= moneySupply;

        if(targetMoney < -1)
            targetMoney = -1;
    }

    public float GetMoneySupply(){
        return moneySupply;
    }

    public void SetMoneySupply(float moneySupply){
        this.moneySupply = moneySupply;
    }


}
