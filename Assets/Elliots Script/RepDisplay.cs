using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RepDisplay : MonoBehaviour
{
    TextMeshProUGUI eventText;

    string repDisplay;

    private void Awake()
    {
        repDisplay = FindObjectOfType<GameManager>().reputation.ToString() + "%";
    }

    // Start is called before the first frame update
    void Start()
    {
        eventText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        eventText.text = repDisplay;
    }
}
