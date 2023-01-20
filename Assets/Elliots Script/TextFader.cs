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
    }

    // Update is called once per frame
    void Update()
    {
        textAlpha = textAlpha + 0.002f;
        if (endText.color != new Color(1, 1, 1, 1f)) 
        {
            endText.color = new Color(1, 1, 1, textAlpha);
        }
            
    }
}
