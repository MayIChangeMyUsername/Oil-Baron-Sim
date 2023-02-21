using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SusDisplay : MonoBehaviour
{
    TextMeshProUGUI susEventText;

    string susDisplay;

  

    // Start is called before the first frame update
    void Start()
    {
        susEventText = GameObject.Find("SusText").GetComponent<TextMeshProUGUI>();
}

    // Update is called once per frame
    void Update()
    {
        susDisplay = FindObjectOfType<GameManager>().sustain.ToString() + "%";
        susEventText.text = susDisplay;
    }
}
