using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

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

#pragma warning restore 0649
    public void Start()
    {
        this.testTextTyper.PrintCompleted.AddListener(this.HandlePrintCompleted);
        this.testTextTyper.CharacterPrinted.AddListener(this.HandleCharacterPrinted);

        this.printNextButton.onClick.AddListener(this.HandlePrintNextClicked);
        this.printNoSkipButton.onClick.AddListener(this.HandlePrintNoSkipClicked);

        dialogueLines.Enqueue("Hello! My name is... Talksalot. Sir Talksalot... Got it, bub?");
        dialogueLines.Enqueue("I need <b>help</b> <i>to</i> <size=40>create</size> <size=20>a textwriter</size> effect. <color=#ff0000ff>Please</color> save <color=#00ff00ff>me...</color>.");
        dialogueLines.Enqueue("I'am <b>BALD</b> ,need me a <b>new</b> hair<b>cut</b>");
        dialogueLines.Enqueue("No<sprite index=0><sprite index=1><sprite index=2><sprite index=3>more sprites... This is painfull.");
        dialogueLines.Enqueue("I can resize <size=40>my </size> ... <size=20>what did u think I was gonna write?</size>");
        dialogueLines.Enqueue("You can have <color=#00ff00ff>a life</color> or <color=#ff0000ff>just put up some ceiling decorations.</color>.");
        dialogueLines.Enqueue("This text can dance, look... <anim=lightrot>Light Roll!!!</anim>, <anim=lightpos>Lez goooo</anim>, <anim=fullshake>I'm gonna puke...</anim>\nwhoopwhoop: <animation=slowsine>Slow Shine</animation>, <animation=bounce>Bounce Bounce>:)</animation>, <animation=crazyflip>Crazy Flip, this one is sick.</animation>");
        ShowScript();
    }

    public void Update()
    {
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