using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private sound[] sound;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (sound s in sound)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.clip;

            s.Source.volume = s.volume;
            s.Source.pitch = s.pitch;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
