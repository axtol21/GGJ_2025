using UnityEngine;

[CreateAssetMenu(fileName = "IncreaseAttackSpeed", menuName = "Scriptable Objects/Upgrades/IncreaseAttackSpeed")]
public class IncreaseAttackSpeed : _Upgrade
{
    public float amount;

    public override void OnBuyFromShop()
    {
        Player.Instance.AttackSpeed += amount;
    }
    public override string GetDescription()
    {
        return $"Increases attack speed by {amount*100}%.";
    }
}
