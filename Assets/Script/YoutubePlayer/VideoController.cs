using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
namespace YoutubePlayer
{
    public class VideoController : MonoBehaviour
    {
        public YoutubePlayer youtubePlayer;
        VideoPlayer videoPlayer;
        public Button bt_play;
        public Button bt_pause;
        public Button bt_Reset;

        private void Awake()
        {
            bt_play.interactable = false;
            bt_pause.interactable = false;
            bt_Reset.interactable = false;
            videoPlayer = youtubePlayer.GetComponent<VideoPlayer>();
            videoPlayer.prepareCompleted += VideoPlayerPreparedCompleted;
        }

        private void VideoPlayerPreparedCompleted(VideoPlayer source)
        {
            bt_play.interactable = source.isPrepared;
            bt_pause.interactable = source.isPrepared;
            bt_Reset.interactable = source.isPrepared;
        }
        public async void Prepare()
        {
            try
            {
                await youtubePlayer.PrepareVideoAsync();
                Console.WriteLine("Video Played");
            }
            catch
            {
                Console.WriteLine("Error.... bro");
            }
        }
        public void PlayVideo()
        {
            videoPlayer.Play();
        }
        public void PauseVideo()
        {
            videoPlayer.Pause();
        }
        public void ResetVideo()
        {
            videoPlayer.Stop();
            videoPlayer.Play();
        }
    }
}

