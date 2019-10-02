using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    private Image image;

    private Sprite m_sprite;

    void Awake(){
        image = GetComponent<Image>();
        m_sprite = image.sprite;
    }
    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        StartCoroutine(Blinking());
    }

    IEnumerator Blinking(){
        float gapTime = 0.2f;        
        for (int i = 0; i < 5; i++)
        {            
            // image.enabled = false;
            image.sprite = null;
            yield return new WaitForSeconds(gapTime);
            // image.enabled = true;
            image.sprite = m_sprite;
            yield return new WaitForSeconds(gapTime);
        }

        gameObject.SetActive(false);
    }
}
