using UnityEngine;
using AC;

public class CameraFollow : MonoBehaviour
{
    [Header("Follow Settings")]
    public float followSpeed = 5f;
    public Vector2 offset = Vector2.zero;

    [Header("Horizontal Bounds")]
    public float minX = -10f;
    public float maxX = 10f;

    [Header("Vertical Bounds")]
    public float minY = -5f;
    public float maxY = 5f;

    private Transform playerTransform;

    void Start()
    {
        if (KickStarter.player != null)
        {
            playerTransform = KickStarter.player.transform;
        }
    }

    void LateUpdate()
    {
        if (playerTransform == null)
        {
            if (KickStarter.player != null)
            {
                playerTransform = KickStarter.player.transform;
            }
            return;
        }

        // Calculate target position
        float targetX = playerTransform.position.x + offset.x;
        float targetY = playerTransform.position.y + offset.y;

        // Clamp to bounds
        float clampedX = Mathf.Clamp(targetX, minX, maxX);
        float clampedY = Mathf.Clamp(targetY, minY, maxY);

        // Build target position keeping camera's Z the same
        Vector3 targetPosition = new Vector3(clampedX, clampedY, transform.position.z);

        // Smoothly move camera to target
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}