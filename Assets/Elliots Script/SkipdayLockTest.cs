using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipdayLockTest : MonoBehaviour
{


    public Button yourButton;

   

   

    //List<string> eventList2 = new List<string>();

   public bool eventBlock;

    public int eventNum;

    // Start is called before the first frame update
    void Start()
    {
        
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        eventBlock =FindObjectOfType<Eventtext>().eventActive;
       

    }

    void TaskOnClick()
    {
        
        eventBlock = true;
        eventNum ++;
        GameManager.week++;
    }
}
