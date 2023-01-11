using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyDisplay : MonoBehaviour
{
    TextMeshProUGUI monEventText;

    string moneyDisplay;

    private void Awake()
    {
        moneyDisplay = FindObjectOfType<GameManager>().money.ToString() + "%";
    }
    // Start is called before the first frame update
    void Start()
    {
        monEventText = GameObject.Find("MoneyText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        monEventText.text = moneyDisplay;
    }
}
