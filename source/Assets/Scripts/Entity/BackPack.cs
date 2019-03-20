using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* 背包类
*/
public class BackPack {
    //背包容量
    public int capacity { get; set; }
    //背包物品（种类ID，数量）
    public Dictionary<int, int> Items { get; set; }
    public BackPack(){
        Items = new Dictionary<int, int>();
        //初始化背包
        capacity = 6;
        Items.Add(0, 1);
    }
}
