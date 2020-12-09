using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    private AudioSource _bgm;
    private AudioSource _attach;
    private AudioSource _miss;
    private AudioSource _collide;
    private void Start()
    {
        _bgm = GetComponents<AudioSource>()[0];
        _attach = GetComponents<AudioSource>()[1];
        _miss = GetComponents<AudioSource>()[2];
        _collide = GetComponents<AudioSource>()[3];
    }

    public void PlayAttach()
    {
        _attach.Play();
    }

    public void PlayMiss()
    {
        _miss.Play();
    }

    public void PlayCollide()
    {
        _collide.Play();
    }
}
