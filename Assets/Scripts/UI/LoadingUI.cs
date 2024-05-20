using UnityEngine;
using UnityEngine.UI;

public class LoadingUI : MonoBehaviour
{
    private Image _progressBarImage;

    [Tooltip("Higher values will move the bar faster. Set to something like 1000 for almost instant.")]
    [SerializeField]  private float progressUpdateSpeed = 3f;

    

    private float _progress = 0f;

    [Tooltip("Loading screen will be displayed for this long at minimum.")]
    public static float MinTimeToLoad = 3f;

    public static float CurrentTimer = 0f;

    private void Awake()
    {
        _progressBarImage = transform.GetComponent<Image>();
    }
    private void Start()
    {
        _progressBarImage.fillAmount = 0;
        CurrentTimer = 0f;
    }
    private void Update()
    {
        _progress = Loader.GetLoadingProgress();
        _progressBarImage.fillAmount = Mathf.Lerp(_progressBarImage.fillAmount, _progress, progressUpdateSpeed * Time.deltaTime);
    }
}
