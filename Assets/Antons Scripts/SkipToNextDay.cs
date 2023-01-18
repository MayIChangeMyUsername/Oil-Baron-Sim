using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipToNextDay : MonoBehaviour
{
    public Button clickButton;
    // Start is called before the first frame update
    void Start()
    {
            Button btn = clickButton.GetComponent<Button>();
            btn.onClick.AddListener(ClickingOnButton);
    }
    void ClickingOnButton()
    {
        Debug.Log("You have clicked the button!");
        GameManager.week++;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
