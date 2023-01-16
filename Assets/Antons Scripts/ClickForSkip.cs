using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickForSkip : MonoBehaviour
{
    public Button ClickFSkip;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = ClickFSkip.GetComponent<Button>();
        btn.onClick.AddListener(ClickingOnCFSButton);
    }
    void ClickingOnCFSButton()
    {
        Debug.Log("You have clicked the button!");
        GameManager.click--;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
