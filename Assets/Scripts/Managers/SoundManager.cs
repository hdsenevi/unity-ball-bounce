using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundFxSource;
    public AudioClip[] collideSounds;
    
    public void PlayRandomColliderSound()
    {
        soundFxSource.clip = collideSounds[Random.Range(0, collideSounds.Length - 1)];
        soundFxSource.Play();
    }
}
