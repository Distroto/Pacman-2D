using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AnimatedSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] sprites = new Sprite[0];
    public float animationTime = 0.25f;
    public int animationFrame { get; private set; }
    public bool loop = true;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Advance), animationTime, animationTime);
    }

    private void Advance()
    {
        if (!this.spriteRenderer.enabled) {
            return;
        }

        this.animationFrame++;

        if (this.animationFrame >= sprites.Length && loop) {
            animationFrame = 0;
        }

        if (this.animationFrame >= 0 && this.animationFrame < sprites.Length) {
            spriteRenderer.sprite = sprites[this.animationFrame];
        }
    }

    public void Restart()
    {
        this.animationFrame = -1;

        Advance();
    }

}