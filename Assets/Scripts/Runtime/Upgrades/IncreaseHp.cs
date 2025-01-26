using UnityEngine;

[CreateAssetMenu(fileName = "IncreaseHp", menuName = "Scriptable Objects/Upgrades/IncreaseHp")]
public class IncreaseHp : _Upgrade
{
    public float amount;

    public override void OnBuyFromShop()
    {
        Player.Instance.MaxHealth += amount;
        Player.Instance.CurrentHealth += amount;
    }
}
