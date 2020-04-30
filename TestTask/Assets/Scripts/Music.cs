using UnityEngine;

public class Music : MonoBehaviour
{
    Animator animator;
    AudioSource mPlay;

    float musicOn = 100.0F;
    float musicOff = 0.0F;
    private void Start()
    {
        mPlay = GetComponent<AudioSource>();
    }
    public void MusicOff()
    {
        mPlay.volume = musicOff;
    }

    public void MusicOn()
    {
        mPlay.volume = musicOn;
    }
}
