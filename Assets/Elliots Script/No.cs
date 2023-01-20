using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No : MonoBehaviour
{
    public Button yourButton;



    

    

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
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            FindObjectOfType<GameManager>().eventNo = true;
            GameObject.Find("NoLjud").GetComponent<AudioSource>().Play();

        }

    }
}
