using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyDisplay : MonoBehaviour
{
    TextMeshProUGUI eventText;

    string moneyDisplay;

    private void Awake()
    {
        moneyDisplay = FindObjectOfType<GameManager>().money.ToString() + "%";
    }
    // Start is called before the first frame update
    void Start()
    {
        eventText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        eventText.text = moneyDisplay;
    }
}
