using System;
using System.Collections;
using System.IO;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Placeholders
    public Rigidbody2D rb;
    public float size = 1.0f;
    public float health = 1.0f;
    public float time = 1.0f;
    [SerializeField] private new Collider2D collider;
    [SerializeField] private new SpriteRenderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TimeToPOP());
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator TimeToPOP()
    {
        yield return new WaitForSeconds(time);
        Player.Instance.CurrentHealth = Player.Instance.CurrentHealth - 1;
        Destroy(gameObject);

        if (Player.Instance.CurrentHealth < 0)
        {
            // Game over
        }
    }

    void OnMouseDown()
    {
        if (Time.time - Player.Instance.LastAttackTime > 1 / Player.Instance.AttackSpeed)
        {
            ApplyDamage(Player.Instance.AttackDamage);
        }
    }

    protected virtual void ApplyDamage(float damageAmount)
    {
        health -= damageAmount;
    }
}
