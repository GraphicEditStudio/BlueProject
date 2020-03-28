using UnityEngine;

public class LevelScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX;

    private Vector3 startPosition;
	private float newPosition;

    private void Start() {
        startPosition = transform.position;
    }

    private void Update() {
        newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
