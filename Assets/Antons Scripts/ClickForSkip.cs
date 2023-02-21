using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickForSkip : MonoBehaviour
{
    public Button ClickFSkip; // En variabel för knappen så att jag kan koppla vilken knapp som ska utföra detta (Anton)
    // Start is called before the first frame update
    void Start()
    {
        Button btn = ClickFSkip.GetComponent<Button>(); //  Hittar vilken knapp vi ska klicka på (Anton)
        btn.onClick.AddListener(ClickingOnCFSButton); // När man klickar på knappen så sker något (Anton)
    }
    void ClickingOnCFSButton()
    {
        Debug.Log("You have clicked the button!"); // när man klickat på knappen så vissas denna text i unity (Anton)
        GameManager.click--; // Ändrar variabeln i gamemanager med ett vid varje klick av knappen (Anton)
    }
    // Update is called once per frame
    void Update()
    {
    }
}
