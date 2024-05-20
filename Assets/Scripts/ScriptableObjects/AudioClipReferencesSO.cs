using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioClipReferencesSO", menuName = "Scriptable Objects/AudioClipReferencesSO")]
public class AudioClipReferencesSO : ScriptableObject
{
    public AudioClip[] projectileGeothermal;
    public AudioClip[] projectileSun;
    public AudioClip[] clickUI;
    public AudioClip[] machineMoving;
    public AudioClip[] damage;
    public AudioClip win;
}
