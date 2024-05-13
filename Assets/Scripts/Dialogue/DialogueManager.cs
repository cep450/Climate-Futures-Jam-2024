using UnityEngine;
using PixelCrushers.DialogueSystem;

public class DialogueManager : MonoBehaviour
{
    private QuestState _tutorialQuest;
    QuestCondition _condition;
    [SerializeField] private DialogueDatabase _gameDatabase;
    private Variable _canStartTutorialDialogue;

    // Start is called before the first frame update
    void Start()
    {
        //_canStartTutorialDialogue = _gameDatabase.GetVariable("IsTutorialDialogueActive");
        DialogueLua.SetVariable("IsTutorialDialogueActive", false);
        //_tutorialQuest.
        
        
    }

    static public void OnConversationStart()
    {

    }
    static public void OnConversationEnd()
    {

    }
    static public void StartQuest()
    {

    }
    static public void StartTutorialDialogue()
    {
        DialogueLua.SetVariable("IsTutorialDialogueActive", true);
        Debug.Log("ISTut " +  DialogueLua.GetVariable("IsTutorialDialogueActive").asBool);
        //var o = new object();
        //o.GetType();
    }
}
