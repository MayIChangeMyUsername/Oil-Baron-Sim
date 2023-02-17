using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yes : MonoBehaviour
{
    public Button yourButton;


    float imageAlpha = 0f;


    Image Yes2;

    Color Yes2Color;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Yes2 = GameObject.Find("No2").GetComponent<Image>();
        Yes2Color = Yes2.color;
        Yes2Color.a = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            TaskOnClick();

        }
    }

    void TaskOnClick()
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            
            FindObjectOfType<GameManager>().eventYes = true;
            FindObjectOfType<YesHoverView>().HideChange();
            GameObject.Find("YesLjud").GetComponent<AudioSource>().Play();
            Yes2.color = Yes2Color;
        }
            
    }
}
