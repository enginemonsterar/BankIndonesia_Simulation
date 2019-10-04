using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class HighLightManager : Singleton<HighLightManager>
{
    
    [SerializeField] private HighlightItem[] highlightItems;
    private int tutorialIndex;
    private List<string> titleStrings = new List<string>();
    private List<string> descStrings = new List<string>();

    [SerializeField] private ImportExportItem riceImportExportItem;
    [SerializeField] private ImportExportItem autoImportExportItem;
    [SerializeField] private ImportExportItem textileImportExportItem;

    [Header("UI")]

    [SerializeField] private Button[] moneySupplyButtons;
    [SerializeField] private GameObject mainBox;
    [SerializeField] private GameObject tutorialBox;
    [SerializeField] private Text titleBoxText;
    [SerializeField] private Text descBoxText;

    [SerializeField] private GameObject nextButton;
    [SerializeField] private HighlightItem tutorialBoxHighlighItem;

    void Awake(){
        AssignString();
    }

    // Start is called before the first frame update
    void Start()
    {
        

        


        ShowTutorial();
        
    }

    public void NextTutorial(){
        if(tutorialIndex < 11){

            tutorialIndex++;
            ShowTutorial();
        }
    }

    void LowlightingAll(){
        //Get All HighlightItems
        var allHighlightItems = (HighlightItem[]) FindObjectsOfType(typeof(HighlightItem));
        for (int i = 0; i < allHighlightItems.Length; i++)
        {            
            allHighlightItems[i].Lowting();   
            
        }   
        tutorialBox.GetComponent<HighlightItem>().Highting();
        
    }

    void HighlightingAll(){
        //Get All HighlightItems
        var allHighlightItems = (HighlightItem[]) FindObjectsOfType(typeof(HighlightItem));
        for (int i = 0; i < allHighlightItems.Length; i++)
        {            
            allHighlightItems[i].Highting();            
            
        }   
        
    }

    public void ShowTutorial(){
        LowlightingAll();
        Debug.Log("Tutorial Index: " + tutorialIndex);
        if(tutorialIndex == 0){
            highlightItems[0].Highting();
            highlightItems[1].Highting();

            titleBoxText.text = titleStrings[tutorialIndex];
            descBoxText.text = descStrings[tutorialIndex];
        }
        else if(tutorialIndex == 1){
            highlightItems[2].Highting();
            highlightItems[3].Highting();

            titleBoxText.text = titleStrings[tutorialIndex];
            descBoxText.text = descStrings[tutorialIndex];
        }
        else if(tutorialIndex == 2){
            highlightItems[4].Highting();
            highlightItems[5].Highting();
            highlightItems[6].Highting();

            titleBoxText.text = titleStrings[tutorialIndex];
            descBoxText.text = descStrings[tutorialIndex];
            
        }else if(tutorialIndex == 3){
            // highlightItems[4].Highting();
            // highlightItems[5].Highting();
            highlightItems[6].Highting();

            titleBoxText.text = titleStrings[2];
            descBoxText.text = descStrings[2];

            // tutorialBoxHighlighItem.Lowting();
            nextButton.SetActive(false);

            riceImportExportItem.NeedExport();


        }else if(tutorialIndex == 4){
            highlightItems[0].Highting();
            highlightItems[1].Highting();
            highlightItems[2].Highting();
            highlightItems[3].Highting();
            highlightItems[4].Highting();
            highlightItems[5].Highting();
            highlightItems[6].Highting();
            highlightItems[7].Highting();
            highlightItems[8].Highting();
            highlightItems[9].Highting();

            titleBoxText.text = titleStrings[2];
            descBoxText.text = descStrings[4];      

            nextButton.SetActive(true);                 
            
        }else if(tutorialIndex == 5){
            highlightItems[4].Highting();
            highlightItems[5].Highting();
            highlightItems[6].Highting();

            titleBoxText.text = titleStrings[3];
            descBoxText.text = descStrings[3];            
            
        }else if(tutorialIndex == 6){
            // highlightItems[4].Highting();
            // highlightItems[5].Highting();
            highlightItems[5].Highting();

            titleBoxText.text = titleStrings[3];
            descBoxText.text = descStrings[3];

            // tutorialBoxHighlighItem.Lowting();
            nextButton.SetActive(false);

            riceImportExportItem.NeedImport();
        }
        else if(tutorialIndex == 7){
            highlightItems[0].Highting();
            highlightItems[1].Highting();
            highlightItems[2].Highting();
            highlightItems[3].Highting();
            highlightItems[4].Highting();
            highlightItems[5].Highting();
            highlightItems[6].Highting();
            highlightItems[7].Highting();
            highlightItems[8].Highting();
            highlightItems[9].Highting();

            titleBoxText.text = titleStrings[3];
            descBoxText.text = descStrings[5];      

            nextButton.SetActive(true);                 
            
        }
        else if(tutorialIndex == 8){
            highlightItems[0].Highting();
            highlightItems[1].Highting();
            highlightItems[2].Highting();
            highlightItems[3].Highting();
            highlightItems[7].Highting();
            highlightItems[8].Highting();
            highlightItems[9].Highting();

            highlightItems[10].Highting();
            tutorialBox.SetActive(false);            
            mainBox.SetActive(true);
            MNumberManager.Instance.OpenMBox(0);
            
        }
        else if(tutorialIndex == 9){

            mainBox.GetComponent<HighlightItem>().Highting();
            highlightItems[0].Highting();
            highlightItems[1].Highting();
            highlightItems[2].Highting();
            highlightItems[3].Highting();
            highlightItems[7].Highting();
            highlightItems[8].Highting();
            highlightItems[9].Highting();
            highlightItems[13].Highting();
            highlightItems[14].Highting();
            highlightItems[15].Highting();

            moneySupplyButtons[0].interactable = true;
            moneySupplyButtons[1].interactable = false;
            highlightItems[11].Highting();
            tutorialBox.SetActive(false);
            mainBox.SetActive(true);
            MNumberManager.Instance.OpenMBox(1);
            
        }
        else if(tutorialIndex == 10){

            mainBox.GetComponent<HighlightItem>().Highting();
            highlightItems[0].Highting();
            highlightItems[1].Highting();
            highlightItems[2].Highting();
            highlightItems[3].Highting();
            highlightItems[7].Highting();
            highlightItems[8].Highting();
            highlightItems[9].Highting();
            highlightItems[13].Highting();
            highlightItems[14].Highting();
            highlightItems[15].Highting();

            moneySupplyButtons[1].interactable = true;
            moneySupplyButtons[2].interactable = false;
            highlightItems[12].Highting();
            tutorialBox.SetActive(false);
            mainBox.SetActive(true);
            MNumberManager.Instance.OpenMBox(2);
            
        }
        else if(tutorialIndex == 11){

            
            moneySupplyButtons[0].interactable = false;
            moneySupplyButtons[1].interactable = true;
            moneySupplyButtons[2].interactable = true;
                                    
            HighlightingAll();

            riceImportExportItem.StartGame();
            autoImportExportItem.StartGame();
            textileImportExportItem.StartGame();
            
            GetComponent<HighLightManager>().enabled = false;

        }

    }

    void AssignString(){
        titleStrings.Add("Deflasi");
        titleStrings.Add("Inflasi");
        titleStrings.Add("Ekspor");
        titleStrings.Add("Impor");

        descStrings.Add("Deflasi adalah suatu periode di mana harga-harga secara umum jatuh dan nilai uang bertambah. deflasi terjadi karena kurangnya jumlah uang yang beredar. Salah satu cara menanggulangi deflasi adalah dengan menurunkan tingkat suku bunga.");
        descStrings.Add("Inflasi merupakan suatu proses meningkatnya harga-harga secara umum dan terus-menerus (continue) berkaitan dengan mekanisme pasar yang dapat disebabkan oleh berbagai faktor, antara lain, konsumsi masyarakat yang meningkat, berlebihnya likuiditas di pasar yang memicu konsumsi atau bahkan spekulasi, sampai termasuk juga akibat adanya ketidaklancaran distribusi barang.");
        descStrings.Add("Ekspor adalah penjualan barang ke luar negeri, pada umumnya adalah tindakan untuk mengeluarkan barang atau komoditas dari dalam negeri untuk memasukannya ke negara lain.");
        descStrings.Add("Impor proses pembelian barang atau jasa asing dari suatu negara ke negara lain. Impor barang secara besar umumnya membutuhkan campur tangan dari bea cukai di negara pengirim maupun penerima.");
        descStrings.Add("Inflasi dapat disebabkan oleh aktivitas ekspor yang berlebihan");
        descStrings.Add("Deflasi dapat disebabkan oleh aktivitas impor yang berlebihan");

    }

}
