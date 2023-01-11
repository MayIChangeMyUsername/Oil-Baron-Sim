using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SusDisplay : MonoBehaviour
{
    TextMeshProUGUI susEventText;

    string susDisplay;

    private void Awake()
    {
        susDisplay = FindObjectOfType<GameManager>().sustain.ToString() + "%";
    }

    // Start is called before the first frame update
    void Start()
    {
        susEventText = FindObjectOfType<TextMeshProUGUI>();
}

    // Update is called once per frame
    void Update()
    {
        susEventText.text = susDisplay;
    }
}
