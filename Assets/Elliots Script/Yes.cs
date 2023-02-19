using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yes : MonoBehaviour
{
    public Button yourButton;


    ImageFade yesImage;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        yesImage = GetComponentInChildren<ImageFade>();

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

            yesImage.FadeIn();
        }
            
    }
}
