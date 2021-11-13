using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Burger : MonoBehaviour
{

    public Slider slider;
    private RectTransform rectTransform;
    float posY;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }


    public void ChangeYPos(float koef)
    {
        posY = slider.value * koef;
        rectTransform.anchoredPosition = new Vector2(0, posY);
    }
   
   
}
