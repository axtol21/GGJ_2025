
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float MaxHealth { get; set; } = 100f;
    public float CurrentHealth { get; set; }
    public float AttackDamage { get; set; } = 1;
    public float AttackSpeed { get; set; } = 1;
    public float MaxTime { get; set; } = 20f;
    public bool CanAttack { get; private set; } = true;
    public float Money { get; set; }
    public int CurrentShopSize { get; set; } = 2;

    public float HpPercent => Mathf.Max(0, CurrentHealth / MaxHealth);

    public float LastAttackTime { get; private set; }

    private Dictionary<string, int> upgrades = new Dictionary<string, int>();

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        CurrentHealth = MaxHealth;
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

}