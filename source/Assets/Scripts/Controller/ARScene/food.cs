using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class food : MonoBehaviour
{
    //实际多是图片，可以使用这个更新图片
    public Image image1;

    public Sprite GetItemImage()
    {
        return image1.sprite;
    }
    public void UpdateItemImage(Sprite icon)
    {
        image1.sprite = icon;
    }
}
