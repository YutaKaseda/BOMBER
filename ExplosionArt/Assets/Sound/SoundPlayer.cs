using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundPlayer{

    GameObject soundPlayer;
    AudioSource audioSource;
    Dictionary<string, AudioClipInfo> audioClips = new Dictionary<string, AudioClipInfo>();

    //AudioClipInfo
    class AudioClipInfo
    {
        public string resourceName;
        public string name;
        public AudioClip clip;

        public AudioClipInfo(string resourceName, string name)
        {
            this.resourceName = resourceName;
            this.name = name;
        }
    }

    public SoundPlayer()
    {
        //SE
        audioClips.Add("PowerCharge", new AudioClipInfo("PowerCharge", "se001"));
        audioClips.Add("CountDown", new AudioClipInfo("CountDown", "se002"));
        audioClips.Add("BombFlying", new AudioClipInfo("BombFlying", "se003"));
        audioClips.Add("Explosion", new AudioClipInfo("Explosion", "se004"));
        audioClips.Add("ObjectBreak", new AudioClipInfo("ObjectBreak", "se005"));
        audioClips.Add("ScoreUp", new AudioClipInfo("ScoreUp", "se006"));
        audioClips.Add("Result", new AudioClipInfo("Result","se007"));
        //BGM
        //audioClips.Add("");
    }

    public bool playSE(string seName)
    {
        if (audioClips.ContainsKey(seName) == false)
            return false;   //not register error

        AudioClipInfo audioclipinfo = audioClips[seName];

        if (audioclipinfo.clip == null)
            audioclipinfo.clip = (AudioClip)Resources.Load("Sound/" + audioclipinfo.resourceName);

        if (soundPlayer == null)
        {
            soundPlayer = new GameObject("SoundPlayer");
            audioSource = soundPlayer.AddComponent<AudioSource>();
        }

        audioSource.PlayOneShot(audioclipinfo.clip);
        
        return true;
    }
	
}
