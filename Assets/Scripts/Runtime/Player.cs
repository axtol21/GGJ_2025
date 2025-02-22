
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float MaxHealth { get; set; }
    public float CurrentHealth { get; set; }
    public float AttackDamage { get; set; }
    public float AttackSpeed { get; set; }
    public float MaxTime { get; set; }
    public float Money { get; set; }
    public float MoneyMultiplier { get; set; }
    public int CurrentShopSize { get; set; } = 2;

    public float HpPercent => Mathf.Max(0, CurrentHealth / MaxHealth);

    public float LastAttackTime { get; set; }

    private Dictionary<string, int> upgrades = new Dictionary<string, int>();

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        Reset();
    }

    public void AddUpgrade(_Upgrade upgrade)
    {
        if (upgrades.ContainsKey(upgrade.key))
        {
            upgrades[upgrade.key] += upgrade.level;
        }
        else
        {
            upgrades[upgrade.key] = upgrade.level;
        }
    }

    public void AddMoney(float amount)
    {
        Money += MoneyMultiplier * amount;
    }

    public void Reset()
    {
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        AttackSpeed = 2;
        AttackDamage = 2;
        MaxTime = 20;
        Money = 0;
        MoneyMultiplier = 1;
    }
}