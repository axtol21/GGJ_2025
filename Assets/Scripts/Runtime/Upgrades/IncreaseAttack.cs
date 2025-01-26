using UnityEngine;

[CreateAssetMenu(fileName = "IncreaseAttack", menuName = "Scriptable Objects/Upgrades/IncreaseAttack")]
public class IncreaseAttack : _Upgrade
{
    public float amount;

    public override void OnBuyFromShop()
    {
        Player.Instance.AttackDamage += amount;
    }
    public override string GetDescription()
    {
        return $"Increases attack by {amount}.";
    }
}
