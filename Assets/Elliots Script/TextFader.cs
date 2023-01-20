using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextFader : MonoBehaviour
{
    TextMeshProUGUI endText;

    float textAlpha = 0f;

    // Start is called before the first frame update
    void Start()
    {
        endText = GameObject.Find("endText").GetComponent<TextMeshProUGUI>();
        endText.color = new Color(0f, 0f, 0f, textAlpha);
    }

    // Update is called once per frame
    void Update()
    {
        textAlpha = textAlpha + 0.0015f;
        if (endText.color != new Color(0f, 0f, 0f, 1f)) 
        {
            endText.color = new Color(0f, 0f, 0f, textAlpha);
        }
            
    }
}
