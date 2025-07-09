# UnityVibeTest

UnityプロジェクトでCubeをマウスクリック時にY軸回転させるサンプルプロジェクトです。

## 概要

このプロジェクトは、Unityの基本的な機能を使用して、シーン内のCubeをマウスの左ボタンクリック時にY軸周りに回転させる機能を実装しています。

## 機能

- **CubeRotatorスクリプト**: マウスの左ボタンが押されている間、CubeをY軸周りに回転
- **新しいInput System対応**: Unity 2022以降の新しいInput Systemを使用
- **調整可能な回転速度**: Inspectorで回転速度を調整可能（デフォルト: 100度/秒）

## 使用方法

1. Unityエディタでプロジェクトを開く
2. SampleSceneを開く
3. Playボタンを押してゲームを開始
4. マウスの左ボタンを押しながらCubeが回転することを確認

## 技術仕様

- **Unity バージョン**: 2022.3以降
- **Input System**: 新しいInput System Package
- **スクリプト言語**: C#
- **対象プラットフォーム**: PC/Mac/Linux

## ファイル構成

```
Assets/
├── Scenes/
│   └── SampleScene.unity          # メインシーン
├── TutorialInfo/
│   └── Scripts/
│       └── CubeRotator.cs         # 回転制御スクリプト
└── InputSystem_Actions.inputactions # Input System設定
```

## 開発環境

- Unity 2022.3 LTS
- Input System Package
- Visual Studio / Visual Studio Code

## ライセンス

このプロジェクトはMITライセンスの下で公開されています。 