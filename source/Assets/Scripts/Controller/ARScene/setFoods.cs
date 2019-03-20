using UnityEngine;
using UnityEditor;
public class setFoods : MonoBehaviour {

 
    void Start () {
        changeSpriteByImage();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void changeSpriteByImage()
    {
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/foods");
        System.Random rd = new System.Random();
        int i = rd.Next(1, 3);
        Sprite spriteB = Resources.Load<Sprite>(null);
        switch (i)
        {
            case 1:
                spriteB = Resources.Load<Sprite>("tomato");
                AddTag("tomato");
                break;
            case 2:
                spriteB = Resources.Load<Sprite>("egg");
                AddTag("egg");
                break;
        }
        this.GetComponent<SpriteRenderer>().sprite = spriteB;
    }
    
    //给预设体加标签（图片名字）
    void AddTag(string tag)
    {
            this.tag = tag;
    }
}
