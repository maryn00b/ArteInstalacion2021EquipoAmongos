using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class MuestraVideo : MonoBehaviour
{
    public string streamingVideoClip;
    VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        player.url = Path.Combine(Application.streamingAssetsPath + streamingVideoClip);
        player.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
