using UnityEngine;

[CreateAssetMenu(fileName = "IncreaseMoneyGained", menuName = "Scriptable Objects/Upgrades/IncreaseMoneyGained")]
public class IncreaseMoneyGained : _Upgrade
{
    public float amount;

    public override void OnBuyFromShop()
    {
        Player.Instance.MoneyMultiplier += amount;
    }
    public override string GetDescription()
    {
        return $"Increases money gained by {amount * 100}%.";
    }
}
