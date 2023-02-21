using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndText : MonoBehaviour
{
    TextMeshProUGUI showText;

    string finalText; 
    // Start is called before the first frame update
    void Start()
    {
        showText = GameObject.Find("endText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //finalText = "Week:" + FindObjectOfType<GameManager>().week.ToString + "";
    }
}
