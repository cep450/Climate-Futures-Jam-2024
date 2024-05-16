using UnityEngine;
using PixelCrushers.DialogueSystem;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject _dialogueTrigger;

    void Awake()
    {
        DialogueLua.SetVariable("IsTutorialDialogueActive", false);
        _dialogueTrigger.SetActive(false);

    }

    /// <summary>
    /// Handle by the Dialogue System Events
    /// </summary>
    public void OnConversationStart()
    {
        // Some Stuff

    }

    /// <summary>
    /// Handle by the Dialogue System Events
    /// </summary>
    public void OnConversationEnd()
    {
        // Some Stuff
    }

    // Rough way. Improvement : Could be handle for the dialogue system
    public void OnConversationSkip()
    {
        _dialogueTrigger.SetActive(false);
    }

    public void StartTutorialDialogue()
    {
        DialogueLua.SetVariable("IsTutorialDialogueActive", true);
        //Debug.Log("ISTut " +  DialogueLua.GetVariable("IsTutorialDialogueActive").asBool);
        _dialogueTrigger.SetActive(true);
    }
}
