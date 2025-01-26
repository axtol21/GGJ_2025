using NUnit.Framework;
using UnityEngine;
using UnityEngine.UIElements;

public class CursorController : MonoBehaviour
{
    public static CursorController Instance;

    [SerializeField] private System.Collections.Generic.List<Texture2D> cursorTextures;
    private float lastFrame;
    private int nextTexture = 0;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Cursor.SetCursor(cursorTextures[9], Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameUI.Instance.GameActive)
        {


            if (((Time.time - Player.Instance.LastAttackTime) > (1 / Player.Instance.AttackSpeed)))
            {
                UnityEngine.Cursor.SetCursor(cursorTextures[9], Vector2.zero, CursorMode.Auto);

                if (Input.GetMouseButtonDown(0))
                {
                    Player.Instance.LastAttackTime = Time.time;
                    lastFrame = Time.time;
                    nextTexture = 0;
                }

            }
            else if (Time.time - lastFrame > ((1 / Player.Instance.AttackSpeed) / cursorTextures.Count))
            {
                if (nextTexture < 10)
                {
                    UnityEngine.Cursor.SetCursor(cursorTextures[nextTexture], Vector2.zero, CursorMode.Auto);
                    nextTexture++;
                }
                lastFrame = Time.time;
            }

        } else
        {
            UnityEngine.Cursor.SetCursor(cursorTextures[9], Vector2.zero, CursorMode.Auto);
            Player.Instance.LastAttackTime = Time.time;
            lastFrame = Time.time;
        }

    }

}
