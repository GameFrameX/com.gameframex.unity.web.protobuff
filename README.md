<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web ProtoBuff

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.web.protobuff)](https://github.com/GameFrameX/com.gameframex.unity.web.protobuff/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.web.protobuff)](https://github.com/GameFrameX/com.gameframex.unity.web.protobuff/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/urKenB9AU)

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## Project Overview

GameFrameX Web ProtoBuff request component - provides HTTP network request functionality based on Protocol Buffer, supporting asynchronous sending and receiving of ProtoBuff messages.

## Features

- **ProtoBuf Support**: Native support for Protocol Buffer message format
- **Async Operations**: `Task<T>` based async API for easy use with `async/await`
- **Timeout Control**: Customizable request timeout
- **Cross-Platform**: Compatible with Unity WebGL and other native platforms

## Requirements

Add the following scripting define symbol in Unity's **Player Settings** -> **Scripting Define Symbols**:

`ENABLE_GAME_FRAME_X_WEB_PROTOBUF_NETWORK`

## Installation (choose one)

1. Add to `manifest.json` dependencies:
   ```json
   {"com.gameframex.unity.web.protobuff": "https://github.com/gameframex/com.gameframex.unity.web.protobuff.git"}
   ```
2. Add via Unity Package Manager using Git URL:
   `https://github.com/gameframex/com.gameframex.unity.web.protobuff.git`
3. Download the repository and place it in your Unity project's `Packages` directory

## Usage Example

```csharp
using GameFrameX.Web.ProtoBuff.Runtime;

// Send request and wait for result
LoginResponse response = await WebComponent.Post<LoginResponse>(url, request);
```
