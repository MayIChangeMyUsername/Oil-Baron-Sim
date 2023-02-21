using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RepDisplay : MonoBehaviour
{
    TextMeshProUGUI repEventText;

    string repDisplay;

 

    // Start is called before the first frame update
    void Start()
    {
        repEventText = GameObject.Find("RepText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        repDisplay = FindObjectOfType<GameManager>().reputation.ToString() + "%";
        repEventText.text = repDisplay;
    }
}
