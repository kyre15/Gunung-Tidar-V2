using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject Detail;
    public GameObject Button;

    public GameObject[] ArrowObject;

    void Start() {
        ShowButtonsandHideDetail();
    }

    public void ShowDetailsandHideButton() {
        Detail.SetActive(true);
        Button.SetActive(false);
        hideAllArrowObject();
    }

    public void ShowButtonsandHideDetail() {
        Detail.SetActive(false);
        Button.SetActive(true);
        showAllArrowObject();
    }

    private void hideAllArrowObject() {
        foreach (GameObject item in ArrowObject) {
            item.SetActive(false);
        }
    }

    private void showAllArrowObject() {
        foreach (GameObject item in ArrowObject) {
            item.SetActive(true);
        }
    }
}
