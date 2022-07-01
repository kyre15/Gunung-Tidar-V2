using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapDisplay : MonoBehaviour
{
    public void changeScene(int index) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }
}
