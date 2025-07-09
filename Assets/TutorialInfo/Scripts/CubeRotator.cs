using UnityEngine;
using UnityEngine.InputSystem;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float maxRotationSpeed = 500f; // 最高回転速度（度/秒）
    [SerializeField] private float accelerationRate = 200f; // 加速率（度/秒²）
    [SerializeField] private float decelerationRate = 100f; // 減速率（度/秒²）
    
    private float currentYRotationSpeed = 0f; // Y軸回転速度
    private float currentXRotationSpeed = 0f; // X軸回転速度
    private bool isYRotating = false;
    private bool isXRotating = false;
    
    void Update()
    {
        // 新しいInput Systemでマウスのボタン状態をチェック
        isYRotating = Mouse.current != null && Mouse.current.leftButton.isPressed;
        isXRotating = Mouse.current != null && Mouse.current.rightButton.isPressed;

        // Y軸回転速度の更新
        if (isYRotating)
        {
            currentYRotationSpeed += accelerationRate * Time.deltaTime;
            currentYRotationSpeed = Mathf.Min(currentYRotationSpeed, maxRotationSpeed);
        }
        else
        {
            currentYRotationSpeed -= decelerationRate * Time.deltaTime;
            currentYRotationSpeed = Mathf.Max(currentYRotationSpeed, 0f);
        }

        // X軸回転速度の更新
        if (isXRotating)
        {
            currentXRotationSpeed += accelerationRate * Time.deltaTime;
            currentXRotationSpeed = Mathf.Min(currentXRotationSpeed, maxRotationSpeed);
        }
        else
        {
            currentXRotationSpeed -= decelerationRate * Time.deltaTime;
            currentXRotationSpeed = Mathf.Max(currentXRotationSpeed, 0f);
        }

        // 回転の適用
        if (currentYRotationSpeed > 0f || currentXRotationSpeed > 0f)
        {
            transform.Rotate(currentXRotationSpeed * Time.deltaTime, currentYRotationSpeed * Time.deltaTime, 0);
        }
    }
} 