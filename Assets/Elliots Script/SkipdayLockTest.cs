using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipdayLockTest : MonoBehaviour
{


    public Button yourButton;

    

   

    //List<string> eventList2 = new List<string>();



   

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
        if(FindObjectOfType<GameManager>().eventActive  == false) 
        {
            FindObjectOfType<GameManager>().eventActive = true;

            GameManager.week++;

            FindObjectOfType<GameManager>().eventArrayNumber = Random.Range(0, 17);

            
        }
       
    }
}
