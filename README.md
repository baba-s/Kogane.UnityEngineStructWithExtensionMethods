# Kogane Unity Engine Struct With Extension Methods

Vector3 や Color などの特定の要素のみを変更できる拡張メソッド

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        // Vector2
        var rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithX( 1 );
        rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithY( 1 );

        // Vector2Int
        var vector2Int = Vector2Int.zero;
        vector2Int = vector2Int.WithX( 1 );
        vector2Int = vector2Int.WithY( 1 );

        // Vector3
        transform.position = transform.position.WithX( 1 );
        transform.position = transform.position.WithY( 1 );
        transform.position = transform.position.WithZ( 1 );

        // Vector3Int
        var vector3Int = Vector3Int.zero;
        vector3Int = vector3Int.WithX( 1 );
        vector3Int = vector3Int.WithY( 1 );
        vector3Int = vector3Int.WithZ( 1 );

        // Color
        var spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = spriteRenderer.color.WithR( 1 );
        spriteRenderer.color = spriteRenderer.color.WithG( 1 );
        spriteRenderer.color = spriteRenderer.color.WithB( 1 );
        spriteRenderer.color = spriteRenderer.color.WithA( 1 );

        // Color32
        var color32 = new Color32( 255, 255, 255, 255 );
        color32 = color32.WithR( 0 );
        color32 = color32.WithG( 0 );
        color32 = color32.WithB( 0 );
        color32 = color32.WithA( 0 );
    }
}
```