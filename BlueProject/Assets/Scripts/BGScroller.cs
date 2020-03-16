using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX;

    private Vector2 startPosition;

    private void Start() {
        startPosition = transform.position;
    }

    private void Update() {
        var newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
        transform.position = startPosition + Vector2.left * newPosition;
    }
}
