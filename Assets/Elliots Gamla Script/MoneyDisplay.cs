using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyDisplay : MonoBehaviour
{


    TextMeshProUGUI monEventText;

    string moneyDisplay;


    // Start is called before the first frame update
    void Start()
    {
        monEventText = GameObject.Find("MoneyText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //det här tar money variabeln från game managern
        moneyDisplay = FindObjectOfType<GameManager>().money.ToString() + "%";
        monEventText.text = moneyDisplay;
    }
}
