

using UnityEngine;
using UnityEngine.UI;


// Controls ambient and gameplay-music volume independently.
public class VolumeSettings : MonoBehaviour
{
    public Slider ambientSlider;
    public Slider gameMusicSlider;

    public AudioSource ambientMusicSource;
    public AudioSource gameMusicSource;

    private void Start()
    {
        if (ambientSlider != null)
            ambientSlider.value = ambientMusicSource != null
                ? ambientMusicSource.volume
                : 1f;

        if (gameMusicSlider != null)
            gameMusicSlider.value = gameMusicSource != null
                ? gameMusicSource.volume
                : 1f;
    }

    public void UpdateAmbientVolume(float volume)
    {
        if (ambientMusicSource != null)
            ambientMusicSource.volume = volume;
    }

    public void UpdateGameMusicVolume(float volume)
    {
        if (gameMusicSource != null)
            gameMusicSource.volume = volume;
    }
}
