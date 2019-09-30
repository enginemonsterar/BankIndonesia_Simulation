using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightItem : MonoBehaviour
{
    private Image imageComponent = null;
    private Color lowColor;
    private Color highColor;
    // Start is called before the first frame update
    void Awake()
    {
        if(GetComponent<Image>())
            imageComponent = GetComponent<Image>();        
    }

    public void Lowting(){
        if ( ColorUtility.TryParseHtmlString("#767676", out lowColor)){
            if(imageComponent)
                imageComponent.color = lowColor; 
        }        
    }

    public void Highting(){
        if ( ColorUtility.TryParseHtmlString("#FFFFFF", out highColor)){
            if(imageComponent)
                imageComponent.color = highColor; 
        }        
    }
}
