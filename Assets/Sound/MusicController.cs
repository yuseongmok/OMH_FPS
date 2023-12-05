using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip yourAudioClip; // 재생할 오디오 클립

    private AudioSource audioSource;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // 오디오 클립을 설정
        audioSource.clip = yourAudioClip;

        // 30초 후에 PlayAudio 함수 호출
        Invoke("PlayAudio", 5f);
    }

    void PlayAudio()
    {
        if (!isPlaying)
        {
            // 오디오 재생
            audioSource.Play();
            isPlaying = true;
        }
    }
}
