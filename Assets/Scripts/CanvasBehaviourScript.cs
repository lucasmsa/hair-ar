using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CanvasBehaviourScript : MonoBehaviour
{ 
    public Image hairImage;
    private GameObject marker;

    public GameObject hairProps;
    public void ActivateHairSprite(Sprite hairSprite) {
        this.hairProps.gameObject.SetActive(true);
        this.hairImage.gameObject.SetActive(true);
        this.hairImage.sprite = hairSprite;
    }

    public void SetColor(Image colorImage) {
        if (this.marker){ 
            Color hairColor = colorImage.color;
            hairColor.a = 1.0f;
            this.marker.GetComponent<Image>().color = hairColor;
        }
    }

    public void HairClick(GameObject marker) {
        this.marker = marker;
    }

    public void VerticalTranslation(float movementY) {
        this.marker.transform.position = new Vector3 (
            marker.transform.position.x,
            (marker.transform.position.y + movementY),
            marker.transform.position.z);
    }

    public void HorizontalTranslation(float movementX) {
        this.marker.transform.position = new Vector3(
            (this.marker.transform.position.x + movementX),
            this.marker.transform.position.y, 
            this.marker.transform.position.z);
    }

    public void ScaleHair(float scaleValue) {
        this.marker.transform.localScale = new Vector3(
            this.marker.transform.localScale.x + scaleValue,
            this.marker.transform.localScale.y  + scaleValue, 
            this.marker.transform.localScale.z);
    }

    public void EliminateHair() {
        this.hairProps.gameObject.SetActive(false);
        this.hairImage.gameObject.SetActive(false);
    }

    public void BackToMenu() 
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
