using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenu;

    public VideoPlayer videoPlayer;

    public void TouchImageMainMenu() {
        HideMainMenu();
        PlayVideoGunungTidarUdara();
    }

    public void SkipVideo() {
        changeScene(1);
    }
    
    private void HideMainMenu() {
        mainMenu.SetActive(false);
    }

    private void PlayVideoGunungTidarUdara() {
        videoPlayer.loopPointReached += EndReached;
        videoPlayer.Play();
    }

    private void EndReached(UnityEngine.Video.VideoPlayer vp) {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
        changeScene(1);
    }

    public void changeScene(int index) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }
}
