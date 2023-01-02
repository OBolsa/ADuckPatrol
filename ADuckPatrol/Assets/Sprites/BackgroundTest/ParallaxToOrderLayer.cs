using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ParallaxToOrderLayer : MonoBehaviour
{
    private SpriteRenderer _Renderer;

    private void Awake()
    {
        _Renderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetOrderLayer();
    }

    private void SetOrderLayer()
    {
        _Renderer.sortingOrder = 1 - (int)(transform.position.z * 100);
    }
}