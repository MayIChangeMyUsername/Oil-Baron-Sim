using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No : MonoBehaviour
{
    public Button yourButton;


    ImageFade noImage;




    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        noImage = GetComponentInChildren<ImageFade>();

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


            noImage.FadeIn();
        }

    }



}
