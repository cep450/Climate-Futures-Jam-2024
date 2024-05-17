using TMPro;
using UnityEngine;
using UnityEngine.UI;

[HelpURL("https://pixelcrushers.com/phpbb/viewtopic.php?t=4345")]
public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] VoidEventChannelSO _pauseEventListener;
    [SerializeField] GameObject _pauseMenuUI;
    [SerializeField] Button _soundEffectsButton;
    [SerializeField] Button _musicButton;
    [SerializeField] Button _mainMenu;
    [SerializeField] TextMeshProUGUI _soundEffectsText;
    [SerializeField] TextMeshProUGUI _musicText;

    private bool _canShow = false;
    private float _soundMultiplier = 10f;

    void Awake()
    {
        _pauseMenuUI.SetActive(false);

        _soundEffectsButton.onClick.AddListener(() =>
        {
            SoundManager.Instance.ChangeVolume();
            UpdateVisual();
        });

        _musicButton.onClick.AddListener(() =>
        {
            MusicManager.Instance.ChangeVolume();
            UpdateVisual();
        });

        _mainMenu.onClick.AddListener(() =>
        {
            FreezeGameplay(_canShow = false);
            Loader.Load(Loader.Scene.MainMenuScene);
        });

    }


    private void OnEnable()
    {
        _pauseEventListener.OnEventRaised += TogglePauseUI;
    }
    private void OnDisable()
    {
        _pauseEventListener.OnEventRaised -= TogglePauseUI;
    }

    private void TogglePauseUI()
    {
        _canShow = !_canShow;

        FreezeGameplay(_canShow);

        _pauseMenuUI.SetActive(_canShow);
    }

    private void FreezeGameplay(bool canshow)
    {
        if (canshow)
        {
            Time.timeScale = 0f;
            PixelCrushers.DialogueSystem.DialogueManager.Pause();
        }
        else
        {
            Time.timeScale = 1.0f;
            PixelCrushers.DialogueSystem.DialogueManager.Unpause();
        }
    }

    private void UpdateVisual()
    {
        _soundEffectsText.text = "Sound Effects: " + Mathf.Round(SoundManager.Instance.GetVolume() * _soundMultiplier);
        _musicText.text = "Music: " + Mathf.Round(MusicManager.Instance.GetVolume() * _soundMultiplier);
    }
}
