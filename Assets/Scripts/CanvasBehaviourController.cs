using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CanvasBehaviourController : MonoBehaviour
{ 
    public Image hairImage;
    public void ActivateHairSprite(Sprite hairSprite) {
        this.hairImage.sprite = hairSprite;
    }
}
