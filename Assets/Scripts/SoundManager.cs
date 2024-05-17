using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private const string PLAYER_PREFS_SOUND_EFFECTS_VOLUME = "SoundsEffectsVolume";

    public static SoundManager Instance { get; private set; }


    [SerializeField] private AudioClipReferencesSO _audioClipReferencesSO;

    private float _volume = 1f;
    private const float DEFAULT_VOLUME = 1f;


    private void Awake()
    {
        Instance = this;
        // DEFAULT_VOLUME would be used if saved data is not found
        _volume = PlayerPrefs.GetFloat(PLAYER_PREFS_SOUND_EFFECTS_VOLUME, DEFAULT_VOLUME);
    }


    
    public void PlayFootstepsSound(Vector3 position, float volume)
    {
        //PlaySound(_audioClipReferencesSO.footstep, position, volume);
    }

    public void PlayCountdownSound()
    {
        //PlaySound(_audioClipReferencesSO.warning, Vector3.zero);
    }

    public void PlayWarningSound(Vector3 position)
    {
        //PlaySound(_audioClipReferencesSO.warning, position);
    }

    private void PlaySound(AudioClip[] audioClipArray, Vector3 position, float volume = 1f)
    {
        PlaySound(audioClipArray[Random.Range(0, audioClipArray.Length)], position, volume);
    }

    private void PlaySound(AudioClip audioClip, Vector3 position, float volumeMultiplier = 1f)
    {
        AudioSource.PlayClipAtPoint(audioClip, position, volumeMultiplier * _volume);
    }


    public void ChangeVolume()
    {
        _volume += 0.1f;

        if (_volume > 1)
            _volume = 0f;

        PlayerPrefs.SetFloat(PLAYER_PREFS_SOUND_EFFECTS_VOLUME, _volume);
        PlayerPrefs.Save();
    }

    public float GetVolume() => _volume;
}
