using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
/*
* 游戏全局变量(即游戏进度)
*/
public class GameGlobal : MonoBehaviour
{
    //用户背包
    public static BackPack backPack = new BackPack();
    //当前关卡
    public static int curGameLevel;
    private void Start()
    {
        Debug.Log("初始化");
        initBackPack();
    }
    private static void initBackPack()
    {

    }
}
