using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yes : MonoBehaviour
{
    public Button yourButton;

    

    public bool yes1;

    public bool yesBlock;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        if (FindObjectOfType<GameManager>().answered == false)
        {
            
            FindObjectOfType<GameManager>().eventYes = true;

        }
            
    }
}
