using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RepDisplay : MonoBehaviour
{
    TextMeshProUGUI repEventText;

    string repDisplay;

    private void Awake()
    {
        repDisplay = FindObjectOfType<GameManager>().reputation.ToString() + "%";
    }

    // Start is called before the first frame update
    void Start()
    {
        repEventText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        repEventText.text = repDisplay;
    }
}
