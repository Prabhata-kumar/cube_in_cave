
using UnityEngine;

[System.Serializable]
public class sound
{
    [SerializeField] private string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [Range(1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource Source;
}
