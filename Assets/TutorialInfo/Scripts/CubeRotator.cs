using UnityEngine;
using UnityEngine.InputSystem;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f; // 回転速度（度/秒）
    
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
        
        // 回転中の場合、Y軸周りに回転
        if (isRotating)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
} 