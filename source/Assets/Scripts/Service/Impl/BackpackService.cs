using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackService : IBackPackService
{
    FoodMaterialDao foodMaterialDao;
    public BackpackService()
    {
        foodMaterialDao = new FoodMaterialDao();
        foodMaterialDao.Start();
    }
    //添加物品
    bool IBackPackService.addItem(int ItemID)
    {
        BackPack backPack = GameGlobal.backPack;
        if (backPack.Items.ContainsKey(ItemID))
        {
            int curNumber = GameGlobal.backPack.Items[ItemID];
            backPack.Items.Add(ItemID, curNumber + 1);
            return true;
        }
        else
        {
            if (backPack.Items.Count < backPack.capacity)
            {
                backPack.Items.Add(ItemID, 1);
                return true;
            }
        }
        return false;
    }

    //返回所有物品
    List<FoodMaterial> IBackPackService.getAllItems()
    {
        List<FoodMaterial> foodMaterials = new List<FoodMaterial>();
        Dictionary<int, int>.KeyCollection keyCol = GameGlobal.backPack.Items.Keys;
        Debug.Log(keyCol.Count);
        foreach (int key in keyCol)
        {
            foodMaterials.Add(foodMaterialDao.selectFoodMaterialByID(key));
            Debug.Log(foodMaterials[0].beforeImgPath);
        }
        return foodMaterials;
    }

    void IBackPackService.dropItem(string name)
    {
        throw new System.NotImplementedException();
    }

    void IBackPackService.getItem(string name)
    {
        throw new System.NotImplementedException();
    }
}
