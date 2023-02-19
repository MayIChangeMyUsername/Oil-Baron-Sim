using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefeatWeekDisplay : MonoBehaviour
{
    TextMeshProUGUI weekText;

    // Start is called before the first frame update
    void Start()
    {
        weekText = GameObject.Find("weekText").GetComponent<TextMeshProUGUI>();

        weekText.text = "Week: " + PlayerPrefs.GetInt("week").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
