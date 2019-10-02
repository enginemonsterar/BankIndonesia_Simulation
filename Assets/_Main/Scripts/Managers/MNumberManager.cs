using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class MNumberManager : Singleton<MNumberManager>
{
    public enum MNumberType
    {
        M0, M1, M2 
    }

    private bool forCetakUangTutorial;
    private bool forGWMTutorial;
    private bool forObligasiTutorial;

    [Header("Main")]
    [SerializeField] private string[] mTitles;
    [SerializeField] private string[] mDescriptions;
    private float mValue;

    [Header("UI")]

    [SerializeField] private Text mValueText;
    [SerializeField] private Button[] mButtons;
    
    [SerializeField] private Text titleTexts;
    private MNumberType nowType = MNumberType.M0;

    public void AddMvalue(){
        mValue += 1;

        if(mValue < 0)
            mValue = 0;

        switch ((int)nowType)
        {
            case 0:
                mValueText.text = "Rp " + mValue + " M";
                break;
            case 1:
                mValueText.text = mValue + "%";
                break;
            case 2:
                mValueText.text = mValue + "";
                break;
            default:
                break;
        }
    }
    public void SubstractMvalue(){
        mValue -= 1;

        if(mValue < 0)
            mValue = 0;
        
        switch ((int)nowType)
        {
            case 0:
                mValueText.text = "Rp " + mValue + " M";
                break;
            case 1:
                mValueText.text = mValue + "%";
                break;
            case 2:
                mValueText.text = mValue + "";
                break;
            default:
                break;
        }


    }

    public void OpenMBox(int index){
        

        nowType = (MNumberType)index;        

        for (int i = 0; i < mButtons.Length; i++)
        {
            mButtons[i].interactable = true;
        }

        mButtons[index].interactable = false;
        titleTexts.text = mTitles[index];

        //reset mValue Text
        mValue = 0;
        
        switch ((int)nowType)
        {
            case 0:
                mValueText.text = "Rp " + mValue + " M";
                break;
            case 1:
                mValueText.text = mValue + "%";
                break;
            case 2:
                mValueText.text = mValue + "";
                break;
            default:
                break;
        }

        

    }

    
    public void SubmitValue(){
        switch ((int)nowType)
        {
            case 0 :
                MoneySupplyManager.Instance.AddSupply(mValue);
                break;
            case 1 :
                MoneySupplyManager.Instance.SubstractSupply(mValue);
                break;
            case 2 :
                MoneySupplyManager.Instance.SubstractSupply(mValue);
                break;
            default:
                MoneySupplyManager.Instance.AddSupply(mValue);
                break;
        }

        //reset mValue Text
        mValue = 0;
        switch ((int)nowType)
        {
            case 0:
                mValueText.text = "Rp " + mValue + " M";
                break;
            case 1:
                mValueText.text = mValue + "%";
                break;
            case 2:
                mValueText.text = mValue + "";
                break;
            default:
                break;
        }

        //ForTutorial
        if(!forCetakUangTutorial){
            forCetakUangTutorial = true;
            HighLightManager.Instance.NextTutorial();
            nowType = MNumberType.M1;
        }
        else if(!forGWMTutorial){
            forGWMTutorial = true;
            HighLightManager.Instance.NextTutorial();
            nowType = MNumberType.M2;
        }
        else if(!forObligasiTutorial){
            forObligasiTutorial = true;
            HighLightManager.Instance.NextTutorial();
            nowType = MNumberType.M0;
            OpenMBox(0);
        }
    }
}
