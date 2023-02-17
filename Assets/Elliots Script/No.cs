using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No : MonoBehaviour
{
    public Button yourButton;


    float imageAlpha = 0f;


    Image No2;

    Color No2Color;

    Color No2ColorReset;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        No2 = GameObject.Find("No2").GetComponent<Image>();
        No2Color = No2.color;
        No2ColorReset = No2.color;
        No2Color.a = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) 
        {
            TaskOnClick();
        
        }
    }
    void TaskOnClick()
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            
            FindObjectOfType<GameManager>().eventNo = true;
            GameObject.Find("NoLjud").GetComponent<AudioSource>().Play();
            No2.color = No2Color;
            
            
        }

    }

    public void ResetColor()
    {
        No2.color = No2ColorReset;
    }

}
