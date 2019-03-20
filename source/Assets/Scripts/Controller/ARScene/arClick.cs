using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//arCamera的点击事件
public class arClick : MonoBehaviour {

	//初始化
	void Start () {
    }
	
	//点击监听
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {   //判断是否是点击事件
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray,out hitInfo) )
            {
                testClick("tomato", hitInfo);
                testClick("egg", hitInfo);
            }
        }
          
	}
    void testClick(string tag , RaycastHit hitInfo)
    {
        if (hitInfo.transform.CompareTag(tag))
        {
            Debug.Log("MOVED451");
            GameObject[] toBeDestroyed = GameObject.FindGameObjectsWithTag(tag);
            if (toBeDestroyed != null)
            {
                for (int i = 0; i < 1; i++)
                {
                    Destroy(toBeDestroyed[i]);
                    toBeDestroyed = null;
                    addFoodToDatabase(tag);
                }
            }

        }
        else
        {
            Debug.Log("12252");

        }

    }


    void addFoodToDatabase(string name)
    {
        //什么也没有
    }
}
