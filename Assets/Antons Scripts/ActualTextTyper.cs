using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;



//Icke fungerande script så komenterade inte detta!!! (Anton)




public class ActualTextTyper : MonoBehaviour
{
    [SerializeField]
    private AudioClip printSoundEffect;

    [Header("UI References")]

    [SerializeField]
    private Button printNextButton;

    [SerializeField]
    private Button printNoSkipButton;

    [SerializeField]
    private Toggle pauseGameToggle;

    private Queue<string> dialogueLines = new Queue<string>();

    [SerializeField]
    [Tooltip("The text typer element to test typing with")]
    private TyperText testTextTyper;

    TextMeshProUGUI eventText;
     string[] eventArray = new string[]
            { "Consumers want lower prices, do you want to reduce prices?",
            "A landowner has offered to sell an area rich in oil. Do you want to buy the land?",
           "The stock market has crashed! Do you wish to fire some of your employees to save money?",
           "Bad rumours about your corporation have begun spreading. Do you want to increase advertising?",
          "An oil leak has appeared and oil is pouring into the ocean.\nDo you want to bribe your employees to make sure nobody finds out about the leak?",
        "Oil consumption has increased and your stocks are rising in value.",
         "Through advertising on social media people's opinion of your company has increased.\nDo you want to spend more money on social media advertising?",
         "A more effective way of producing oil has been developed!",
        "Demand for oil has rapidly begun increasing. Do you want to accelerate the production rate to satisfy demand?",
        "Your phone is ringing, and it’s from a known swindler. Maybe he has a business proposal for you..?",
         "People are protesting outside your office. Do you want to bribe the police to stop them?",
         "One of your oil rigs is in need of massive repairs. You could either hire experienced workers who can repair without harming marine life,\nor let your own workers repair despite the damage it would cause. Do you want to hire outsourced workers?",
          "One of your oil tankers has sunk, leaving large amounts of oil in the ocean. Do you want to clean it up?",
          "A reporter has asked for a tour on one of your oil rigs. Do you accept the request?",
          "A competing oil corporation has caused an extraordinarily large oil spillage. This has caused outrage against the oil industry. Do you wish to make a public statement?",
         "The government has offered your company subsidies in exchange for us lowering our prices. Do you agree to the deal?",
         "An oil extraction method which is much less harmful for nature has been invented. However it is also more expensive. Do you want to adopt the new method?",
          "A news site has just published a hit piece, detailing some of our shady business practices.\nDo you want to blame a few of your own employees and fire them?"
     };
#pragma warning restore 0649
    public void Start()
    {
        eventText = GameObject.Find("Lore").GetComponent<TextMeshProUGUI>();

        this.testTextTyper.PrintCompleted.AddListener(this.HandlePrintCompleted);
        this.testTextTyper.CharacterPrinted.AddListener(this.HandleCharacterPrinted);

        this.printNextButton.onClick.AddListener(this.HandlePrintNextClicked);
        this.printNoSkipButton.onClick.AddListener(this.HandlePrintNoSkipClicked);

        dialogueLines.Enqueue("aaaaaaaaa aaaa aa a a a aaaa aa");
        ShowScript();

    }

    public void Update()
    {

        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            eventText.text = eventArray[FindObjectOfType<GameManager>().eventArrayNumber];
        }
        else
        {
            eventText.text = "";
        }


        UnityEngine.Time.timeScale = this.pauseGameToggle.isOn ? 0.0f : 1.0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            var tag = RichTextTag.ParseNext("blah<color=red>boo</color");
            LogTag(tag);
            tag = RichTextTag.ParseNext("<color=blue>blue</color");
            LogTag(tag);
            tag = RichTextTag.ParseNext("No tag in here");
            LogTag(tag);
            tag = RichTextTag.ParseNext("No <color=blueblue</color tag here either");
            LogTag(tag);
            tag = RichTextTag.ParseNext("This tag is a closing tag </bold>");
            LogTag(tag);
        }
    }

    private void HandlePrintNextClicked()
    {
        if (this.testTextTyper.IsSkippable() && this.testTextTyper.IsTyping)
        {
            this.testTextTyper.Skip();
        }
        else
        {
            ShowScript();
        }
    }

    private void HandlePrintNoSkipClicked()
    {
        ShowScript();
    }

    private void ShowScript()
    {
        if (dialogueLines.Count <= 0)
        {
            return;
        }

        this.testTextTyper.TypeText(dialogueLines.Dequeue());
    }

    private void LogTag(RichTextTag tag)
    {
        if (tag != null)
        {
            Debug.Log("Tag: " + tag.ToString());
        }
    }

    private void HandleCharacterPrinted(string printedCharacter)
    {
        if (printedCharacter == " " || printedCharacter == "\n")
        {
            return;
        }

        var audioSource = this.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = this.gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = this.printSoundEffect;
        audioSource.Play();
    }

    private void HandlePrintCompleted()
    {
        Debug.Log("TypeText Complete!");
    }
}