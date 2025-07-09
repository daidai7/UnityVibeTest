# UnityVibeTest

UnityプロジェクトでCubeをマウスクリック時に軸回転させるサンプルプロジェクトです。

## 概要

このプロジェクトは、Unityの基本的な機能を使用して、シーン内のCubeをマウスクリック時に軸周りに回転させる機能を実装しています。加速・減速システムにより、自然で滑らかな回転動作を提供し、リアルタイムで回転速度を表示します。

## 機能

- **CubeRotatorスクリプト**: マウスクリック時にCubeを軸周りに回転
- **左クリック**: Y軸回転（加速・減速システム）
- **右クリック**: X軸回転（加速・減速システム）
- **同時押し**: 両軸同時に回転
- **リアルタイム速度表示**: 画面上部にX軸・Y軸の回転速度を表示
- **新しいInput System対応**: Unity 2022以降の新しいInput Systemを使用
- **調整可能なパラメータ**: Inspectorで回転速度、加速率、減速率を調整可能

## 操作方法

1. Unityエディタでプロジェクトを開く
2. SampleSceneを開く
3. Playボタンを押してゲームを開始
4. マウス操作でCubeを回転：
   - **左クリック**: Y軸周りに回転（縦回転）
   - **右クリック**: X軸周りに回転（横回転）
   - **両方同時**: 両軸同時に回転
5. 画面左上でリアルタイム速度を確認

## 回転システム

### 加速・減速システム
- **加速**: ボタンを押している間、徐々に回転速度が増加
- **最高速度**: 500度/秒（デフォルト）
- **減速**: ボタンを離すと、徐々に回転速度が減少
- **停止**: 速度が0になると回転停止

### パラメータ設定
- **Max Rotation Speed**: 最高回転速度（度/秒）
- **Acceleration Rate**: 加速率（度/秒²）
- **Deceleration Rate**: 減速率（度/秒²）

## 速度表示UI

### 表示内容
- **X Speed**: 右クリック時の回転速度（deg/s）
- **Y Speed**: 左クリック時の回転速度（deg/s）
- **リアルタイム更新**: 加速・減速に合わせて数値が変化

### UI位置
- 画面左上に表示（左端から150px）
- 白色テキスト、24pxフォントサイズ

## 技術仕様

- **Unity バージョン**: 2022.3以降
- **Input System**: 新しいInput System Package
- **UI System**: TextMeshProを使用
- **スクリプト言語**: C#
- **対象プラットフォーム**: PC/Mac/Linux

## ファイル構成

```
Assets/
├── Scenes/
│   └── SampleScene.unity          # メインシーン
├── TutorialInfo/
│   └── Scripts/
│       ├── CubeRotator.cs         # 回転制御スクリプト
│       └── SpeedUI.cs             # 速度表示UIスクリプト
├── TextMesh Pro/                  # TextMeshProパッケージ
└── InputSystem_Actions.inputactions # Input System設定
```

## 開発環境

- Unity 2022.3 LTS
- Input System Package
- TextMeshPro Package
- Visual Studio / Visual Studio Code

## ライセンス

このプロジェクトはMITライセンスの下で公開されています。 