using UnityEngine;

[CreateAssetMenu(fileName = "UnlockRerolls", menuName = "Scriptable Objects/Upgrades/UnlockRerolls")]
public class UnlockRerolls : _Upgrade
{
    public override void OnBuyFromShop()
    {
        GameUI.Instance.UnlockRerolls();
        GameUI.Instance.RemoveUpgradeFromShopPool(this);
    }

    public override string GetDescription()
    {
        return "Enables rerolling the shop, for a price.";
    }
}
