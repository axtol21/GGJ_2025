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
    public float damageToDeal = 1.0f;
    public float money = 1.0f;
    [SerializeField] private AnimationCurve xAnimation;
    [SerializeField] private AnimationCurve yAnimation;
    private float animationTime = 1.0f;
    private bool destroyed = false;

    [SerializeField] private new Collider2D collider;
    [SerializeField] private new SpriteRenderer renderer;
    [SerializeField] private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TimeToPOP());
        LevelManager.TotalBubbleCount += 1;
    }

    // Update is called once per frame
    void Update()
    {

        animationTime += Time.deltaTime;
        renderer.transform.localScale = new Vector3(xAnimation.Evaluate(animationTime), yAnimation.Evaluate(animationTime), 1);

    }

    private IEnumerator TimeToPOP()
    {
        yield return new WaitForSeconds(time);
        Player.Instance.CurrentHealth = Player.Instance.CurrentHealth - damageToDeal;

        if (Player.Instance.CurrentHealth < 0)
        {
            // Game over
            Debug.Log("Game OVER!");
        }

        DestroyBubble();
    }

    void OnMouseDown()
    {
        if ((Time.time - Player.Instance.LastAttackTime) > (1 / Player.Instance.AttackSpeed))
        {
            OnCollisionEnter2D(null);
            ApplyDamage(Player.Instance.AttackDamage);

            if (health <= 0 && !destroyed)
            {
                Player.Instance.Money += money;
                DestroyBubble();
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animationTime = 0;
    }

    protected virtual void ApplyDamage(float damageAmount)
    {
        health -= damageAmount;
    }

    private void DestroyBubble()
    {
        if (!destroyed)
        {
            destroyed = true;
            animator.SetTrigger("pop");
            LevelManager.TotalBubbleCount -= 1;
            Destroy(gameObject, 0.5f);
        }
    }
}