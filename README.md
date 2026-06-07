<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web ProtoBuff

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.web.protobuff)](https://github.com/GameFrameX/com.gameframex.unity.web.protobuff/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.web.protobuff)](https://github.com/GameFrameX/com.gameframex.unity.web.protobuff/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

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

## Quick Start

### Installation

### Installation

Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

`scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.web.protobuff": "1.1.3"
  }
}
```


## Usage Example

```csharp
using GameFrameX.Web.ProtoBuff.Runtime;

// Send request and wait for result
LoginResponse response = await WebComponent.Post<LoginResponse>(url, request);
```
