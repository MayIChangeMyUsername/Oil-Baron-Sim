using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickForSkip : MonoBehaviour
{
    [SerializeField]
    KeyCode mouseclick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CFS();
    }
    void CFS()
    {
        if (Input.GetKeyDown(mouseclick))
        {
            GameManager.click--;
        }
    }
}
