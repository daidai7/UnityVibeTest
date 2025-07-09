using UnityEngine;
using UnityEngine.InputSystem;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float maxRotationSpeed = 500f; // 最高回転速度（度/秒）
    [SerializeField] private float accelerationRate = 200f; // 加速率（度/秒²）
    [SerializeField] private float decelerationRate = 100f; // 減速率（度/秒²）
    
    private float currentRotationSpeed = 0f; // 現在の回転速度
    private bool isRotating = false;
    
    void Update()
    {
        // 新しいInput Systemでマウスの左ボタンが押されているかチェック
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            isRotating = true;
        }
        else
        {
            isRotating = false;
        }
        
        // 回転速度の更新
        if (isRotating)
        {
            // 加速
            currentRotationSpeed += accelerationRate * Time.deltaTime;
            currentRotationSpeed = Mathf.Min(currentRotationSpeed, maxRotationSpeed);
        }
        else
        {
            // 減速
            currentRotationSpeed -= decelerationRate * Time.deltaTime;
            currentRotationSpeed = Mathf.Max(currentRotationSpeed, 0f);
        }
        
        // 回転の適用
        if (currentRotationSpeed > 0f)
        {
            transform.Rotate(0, currentRotationSpeed * Time.deltaTime, 0);
        }
    }
} 