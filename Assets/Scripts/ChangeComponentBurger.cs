using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeComponentBurger : MonoBehaviour
{
    public Image OldImage;
    public Sprite newImage;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public  void ImageChange()
    {

        OldImage.sprite = newImage;
    }
}
