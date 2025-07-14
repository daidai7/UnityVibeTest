using UnityEngine;
using TMPro;

public class SpeedUI : MonoBehaviour
{
    [Header("UI Settings")]
    [SerializeField] private Color textColor = Color.white; // テキスト色
    [SerializeField] private int fontSize = 24; // フォントサイズ
    
    private TextMeshProUGUI xSpeedText;
    private TextMeshProUGUI ySpeedText;
    
    void Awake()
    {
        CreateSpeedUI();
    }
    
    void Start()
    {
        // CubeRotatorにUIテキストを設定
        SetupCubeRotator();
    }
    
    void CreateSpeedUI()
    {
        Debug.Log("Creating SpeedUI...");
        
        // Canvasの作成（SimpleUITestと同じ方法）
        GameObject canvasObj = new GameObject("SpeedCanvas");
        Canvas canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 999; // 最前面に表示
        
        // X軸速度表示テキストの作成
        GameObject xSpeedObj = new GameObject("XSpeedText");
        xSpeedObj.transform.SetParent(canvasObj.transform, false);
        xSpeedText = xSpeedObj.AddComponent<TextMeshProUGUI>();
        xSpeedText.text = "X Speed: 0.0 deg/s";
        xSpeedText.fontSize = fontSize;
        xSpeedText.color = textColor;
        xSpeedText.alignment = TextAlignmentOptions.Left;
        
        // X軸速度表示の位置設定（左上に表示、さらに右に移動）
        RectTransform xRect = xSpeedText.GetComponent<RectTransform>();
        xRect.anchorMin = new Vector2(0, 1);
        xRect.anchorMax = new Vector2(0, 1);
        xRect.anchoredPosition = new Vector2(150, -50); // 左上からさらに右に移動
        xRect.sizeDelta = new Vector2(250, 40);
        
        // Y軸速度表示テキストの作成
        GameObject ySpeedObj = new GameObject("YSpeedText");
        ySpeedObj.transform.SetParent(canvasObj.transform, false);
        ySpeedText = ySpeedObj.AddComponent<TextMeshProUGUI>();
        ySpeedText.text = "Y Speed: 0.0 deg/s";
        ySpeedText.fontSize = fontSize;
        ySpeedText.color = textColor;
        ySpeedText.alignment = TextAlignmentOptions.Left;
        
        // Y軸速度表示の位置設定（左上に表示、さらに右に移動）
        RectTransform yRect = ySpeedText.GetComponent<RectTransform>();
        yRect.anchorMin = new Vector2(0, 1);
        yRect.anchorMax = new Vector2(0, 1);
        yRect.anchoredPosition = new Vector2(150, -20); // 左上からさらに右に移動
        yRect.sizeDelta = new Vector2(250, 40);
        
        Debug.Log("SpeedUI created successfully");
    }
    
    void SetupCubeRotator()
    {
        Debug.Log("Setting up CubeRotator...");
        
        // CubeRotatorスクリプトにUIテキストを設定
        CubeRotator cubeRotator = FindFirstObjectByType<CubeRotator>();
        if (cubeRotator != null)
        {
            cubeRotator.xSpeedText = xSpeedText;
            cubeRotator.ySpeedText = ySpeedText;
            Debug.Log("CubeRotator UI setup completed");
        }
        else
        {
            Debug.LogError("CubeRotator not found!");
        }
    }
} 