using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource; // Ses kaynağı referansı
    public Button toggleMusicButton; // Buton referansı

    private bool isPlaying = true;

    void Start()
    {
        // Buton tıklandığında ToggleMusic fonksiyonunu çağır
        toggleMusicButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isPlaying)
        {
            audioSource.Pause(); // Müziği durdur
        }
        else
        {
            audioSource.Play(); // Müziği başlat
        }

        isPlaying = !isPlaying; // Durum değiştir
    }
}

