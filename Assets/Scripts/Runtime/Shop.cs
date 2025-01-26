using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject upgradePrefab;

    [SerializeField] private Transform shopContainer;

    [SerializeField] private List<_Upgrade> upgradePool;

    [SerializeField] private TextMeshProUGUI rerollCostDisplay;

    private float _rerollCost;

    public float RerollCost
    {
        get
        {
            return _rerollCost;
        } 
        set
        {
            var valueStr = value.ToString();
            rerollCostDisplay.text = $"<cspace=-0.5em><voffset=0.275em><sprite=\"1bit 16px icons part-2\" index=81></voffset>{valueStr[0]}</cspace>{valueStr[1..]}";
            _rerollCost = value;
        }
    }

    public void RerollShop()
    {
        for (int i = shopContainer.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(shopContainer.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < Player.Instance.CurrentShopSize; i++)
        {
            var upgradeObj = Instantiate(upgradePrefab, shopContainer);
            var upgradeSlot = upgradeObj.GetComponent<ShopUpgradeSlot>();

            upgradeSlot.SetUpgrade(upgradePool[LevelManager.Random.Next(upgradePool.Count)]);
        }

        RerollCost += 100;
    }

    public void RemoveUpgradesFromShopPool(_Upgrade upgrade)
    {
        for (int i =  upgradePool.Count - 1; i >= 0; i--)
        {
            if (upgradePool[i].key == upgrade.key)
            {
                upgradePool.RemoveAt(i);
            }
        }
    }
}
