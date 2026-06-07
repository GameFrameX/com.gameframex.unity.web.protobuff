<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web ProtoBuff

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.web.protobuff)](https://github.com/GameFrameX/com.gameframex.unity.web.protobuff/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.web.protobuff)](https://github.com/GameFrameX/com.gameframex.unity.web.protobuff/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#quick-start) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## 项目简介

GameFrameX 的 Web ProtoBuff 请求组件 - 提供基于 Protocol Buffer 的 HTTP 网络请求功能，支持异步发送和接收 ProtoBuff 消息。

## 功能概述

- **ProtoBuf 支持**: 原生支持 Protocol Buffer 消息格式
- **异步操作**: 基于 `Task<T>` 的异步 API，方便使用 `async/await`
- **超时控制**: 支持自定义请求超时时间
- **跨平台**: 兼容 Unity WebGL 及其他原生平台

## 环境要求

使用本组件需要在 Unity 的 **Player Settings** -> **Scripting Define Symbols** 中添加以下宏定义：

`ENABLE_GAME_FRAME_X_WEB_PROTOBUF_NETWORK`

## 安装方式（任选其一）

1. 直接在 `manifest.json` 的文件中的 `dependencies` 节点下添加以下内容
   ```json
   {"com.gameframex.unity.web.protobuff": "https://github.com/gameframex/com.gameframex.unity.web.protobuff.git"}
   ```
2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.web.protobuff.git`
3. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下。会自动加载识别

## 使用示例

```csharp
using GameFrameX.Web.ProtoBuff.Runtime;

// 发送请求并等待结果
LoginResponse response = await WebComponent.Post<LoginResponse>(url, request);
```
