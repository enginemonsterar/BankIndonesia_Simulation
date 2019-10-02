using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MNumberManager : MonoBehaviour
{
    public enum MNumberType
    {
        M0, M1, M2 
    }

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
        mValue += 100;
        mValueText.text = mValue + "";
    }
    public void SubstractMvalue(){
        mValue -= 100;
        mValueText.text = mValue + "";
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
        mValueText.text = mValue + "";

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
        mValueText.text = mValue + "";
    }
}
