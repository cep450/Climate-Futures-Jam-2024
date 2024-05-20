using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private const string PLAYER_PREFS_MUSIC_VOLUME = "MusicVolume";

    public static MusicManager Instance { get; private set; }


    private AudioSource _audioSource;
    private float _volume = 0.3f;
    private const float DEFAULT_VOLUME = 0.3f;


    private void Awake()
    {
        Instance = this;

        _audioSource = GetComponent<AudioSource>();

        // DEFAULT_VOLUME would be used if saved data is not found
        _volume = PlayerPrefs.GetFloat(PLAYER_PREFS_MUSIC_VOLUME, DEFAULT_VOLUME);

        _audioSource.volume = _volume;
    }

    public void ChangeVolume()
    {
        _volume += 0.1f;

        if (_volume > 1f)
            _volume = 0f;
        _audioSource.volume = _volume;

        PlayerPrefs.SetFloat(PLAYER_PREFS_MUSIC_VOLUME, _volume);
        PlayerPrefs.Save();
    }

    public float GetVolume() => _volume;

}
