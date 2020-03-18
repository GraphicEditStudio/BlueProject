using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX;

    private Vector2 startPosition;
	private float newPosition;

    private void Start() {
        startPosition = transform.position;
    }

    private void Update() {
        newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
        transform.position = startPosition + Vector2.left * newPosition;
    }
}
