using UnityEngine;

[CreateAssetMenu(fileName = "UnlockShopSlot", menuName = "Scriptable Objects/Upgrades/UnlockShopSlot")]
public class UnlockShopSlot : _Upgrade
{
    public override void OnBuyFromShop()
    {
        if (Player.Instance.CurrentShopSize < 4)
        {
            Player.Instance.CurrentShopSize++;
        }

        if (Player.Instance.CurrentShopSize >= 4)
        {
            GameUI.Instance.RemoveUpgradeFromShopPool(this);
        }
    }

    public override string GetDescription()
    {
        return "Increases the shop size by 1 (max 4).";
    }
}
