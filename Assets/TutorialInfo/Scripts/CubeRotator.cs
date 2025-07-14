using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CubeRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float maxRotationSpeed = 500f;      // 最大回転速度（deg/s）
    [SerializeField] private float acceleration = 200f;          // 加速度（deg/s²）
    [SerializeField] private float deceleration = 100f;          // 減速度（deg/s²）

    [Header("UI Elements")]
    public TextMeshProUGUI xSpeedText;
    public TextMeshProUGUI ySpeedText;

    private float xSpeed = 0f;
    private float ySpeed = 0f;

    void Start()
    {
        UpdateSpeedUI();
        Debug.Log($"CubeRotator started - UI elements: X:{(xSpeedText != null)}, Y:{(ySpeedText != null)}");
    }

    void Update()
    {
        UpdateRotationSpeed(ref xSpeed, Mouse.current?.rightButton.isPressed ?? false);
        UpdateRotationSpeed(ref ySpeed, Mouse.current?.leftButton.isPressed ?? false);
        ApplyRotation();
        UpdateSpeedUI();
    }

    private void UpdateRotationSpeed(ref float speed, bool isPressed)
    {
        if (isPressed)
        {
            speed += acceleration * Time.deltaTime;
            speed = Mathf.Min(speed, maxRotationSpeed);
        }
        else
        {
            speed -= deceleration * Time.deltaTime;
            speed = Mathf.Max(speed, 0f);
        }
    }

    private void ApplyRotation()
    {
        if (xSpeed > 0f || ySpeed > 0f)
        {
            transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, 0f);
        }
    }

    private void UpdateSpeedUI()
    {
        if (xSpeedText != null)
            xSpeedText.text = $"X Speed: {xSpeed:F1} deg/s";
        if (ySpeedText != null)
            ySpeedText.text = $"Y Speed: {ySpeed:F1} deg/s";
    }
} 