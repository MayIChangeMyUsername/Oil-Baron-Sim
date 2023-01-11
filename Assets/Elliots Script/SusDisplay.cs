using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SusDisplay : MonoBehaviour
{
    TextMeshProUGUI eventText;

    string susDisplay;

    private void Awake()
    {
        susDisplay = FindObjectOfType<GameManager>().sustain.ToString() + "%";
    }

    // Start is called before the first frame update
    void Start()
    {
        eventText = FindObjectOfType<TextMeshProUGUI>();
}

    // Update is called once per frame
    void Update()
    {
        eventText.text = susDisplay;
    }
}
