using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImportExportItem : MonoBehaviour
{
    [SerializeField] private Button[] imExButtons;

    private bool forExTutorial;
    private bool forImTutorial;

    void Start(){
                
    }

    public void StartGame(){
        CancelInvoke("NeedImport");
        CancelInvoke("NeedExport");

        Invoke("NeedImport",Random.Range(15,30));
        Invoke("NeedExport",Random.Range(15,30));
    }

    public void NeedImport(){
        imExButtons[0].interactable = true;
        imExButtons[0].transform.GetChild(0).gameObject.SetActive(true);
    }

    public void NeedExport(){
        imExButtons[1].interactable = true;
        imExButtons[1].transform.GetChild(0).gameObject.SetActive(true);

        
    }

    public void DoImport(){

        imExButtons[0].interactable = false;
        imExButtons[0].transform.GetChild(0).gameObject.SetActive(false);
        imExButtons[0].transform.GetChild(1).gameObject.SetActive(true);

        MoneySupplyManager.Instance.SubstractSupply(Random.Range(10,20));

        if(!forImTutorial){
            forImTutorial = true;
            HighLightManager.Instance.NextTutorial();
        }else{

            //reset invoke
            CancelInvoke("NeedImport");
            Invoke("NeedImport",Random.Range(15,30));
        }

        
    }

    public void DoExport(){

        imExButtons[1].interactable = false;
        imExButtons[1].transform.GetChild(0).gameObject.SetActive(false);
        imExButtons[1].transform.GetChild(1).gameObject.SetActive(true);

        MoneySupplyManager.Instance.AddSupply(Random.Range(10,20));

        if(!forExTutorial){
            forExTutorial = true;
            HighLightManager.Instance.NextTutorial();
        }        
        else{
            //reset invoke
            CancelInvoke("NeedExport");
            Invoke("NeedExport",Random.Range(15,30));
        }

        
    }



}
