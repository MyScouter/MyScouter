using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    #region singelton
    public static StreamVideo instance;
    private void Awake()
    {
        raw.enabled = false;
        if (instance != null)
            return;
        instance = this;
    }

    #endregion
    public RawImage raw;
    public VideoPlayer video;
    //public AudioSource source;
  
    
    public IEnumerator playVideo()
    {

        raw.enabled = true;
        video.Prepare();
        while (!video.isPrepared)
        {
            yield return new WaitForSeconds(1);
            break;
        }
        raw.enabled = true;
        raw.texture = video.texture;
        video.Play();
        //source.Play();
        while (video.isPlaying)
        {
            yield return null;
        }
        raw.enabled = false;
    }

 
}
