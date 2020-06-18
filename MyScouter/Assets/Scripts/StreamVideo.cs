using System.Collections;
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
    public string[] videoName;
    //public AudioSource source;
    private void Start()
    {
        videoName= new string[]{"FIFA practice1.mp4", "FIFA practice2.mp4" , "FIFA practice3.mp4" , "FIFA practice4.mp4" , "Eating.mp4" , "gameWin.mp4" , "Game lost.mp4" };
    }

    public IEnumerator playVideo(int num)
    {
        int number = num;
        if (num == -1)
        {
            System.Random random = new System.Random();
            number = random.Next(0, 3);
        }
        video.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoName[number]);
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
