using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VoiceManager : MonoBehaviour
{
    public Slider voice_slider;
    public AudioSource Bgm;
    public Toggle voice_toggle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        toggleChangeVoice();
    }
    private void SetVoice() 
    {
        Bgm.volume = voice_slider.value;
    }
    public void toggleChangeVoice()
    {
        if (voice_toggle.isOn == true)
        {
            Bgm.GetComponent<AudioSource>().enabled = true;
            SetVoice();
        }
        else
        {
            Bgm.GetComponent<AudioSource>().enabled = false;
        }
    }

}
