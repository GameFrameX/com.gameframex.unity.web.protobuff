# [2.0.0](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.5...2.0.0) (2026-10-15)


### Features

* **web.protobuff:** 承接 MessageHttpObject 与 protobuf 契约注册 ([81ae4a1](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/81ae4a10a19efd88035e2f1878833c33201cb032))
* **web.protobuff:** 模块契约全接口化迁移 ([08050b8](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/08050b862fa4f445e75faac53a8b7faf9210a566))


### BREAKING CHANGES

* **web.protobuff:** 模块契约全接口化，删除 GameFrameworkModule
抽象基类依赖；业务侧仍通过 GetModule<IWebProtoBuffManager>()
访问模块，不受影响。

# [2.0.0](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.5...2.0.0) (2026-10-08)


### ⚠ BREAKING CHANGES

* **module:** 模块契约全接口化：删除 `GameFrameworkModule` 抽象基类，改为 `IGameFrameworkModule` 标记接口 + 可选能力接口

**新契约形态与迁移对照：**

| 旧基类成员 | 新契约 | 迁移方式 |
|---|---|---|
| `: GameFrameworkModule` | `IGameFrameworkModule` | 声明处直接替换（标记接口，可注册进 `GameFrameworkEntry`） |
| `override void Update(float, float)` | `IUpdatableModule` | 真实实现改 `public`；空实现删除（未实现者不再被轮询） |
| `override void Shutdown()` | `IShutdownableModule` | 真实实现改 `public`；空实现删除（未实现者不再被关闭） |
| `override int Priority` | `IPrioritizedModule` | 改 `public int Priority { get; }`；未实现视为 0 |

本包变更：`WebProtoBuffManager` 实现 `IUpdatableModule`、`IShutdownableModule`。

`GameFrameworkEntry.Update` 仅分派 `IUpdatableModule`；`Shutdown` 按优先级反序仅分派 `IShutdownableModule`；tick 与关闭顺序与旧实现完全一致。能力方法仅由宿主入口调用，业务侧继续通过 `GetModule<IXxxManager>()` 访问模块。

## [1.1.5](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.4...1.1.5) (2026-07-29)


### Bug Fixes

* 更新 package.json 中的依赖版本 ([7daaefb](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/7daaefb80bc964bd523ccb9b0682d93c0df852fb))

## [1.1.4](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.3...1.1.4) (2026-06-07)


### Bug Fixes

* 补全包规范文件（LICENSE/CHANGELOG/URL 字段/unity 字段） ([5d924b5](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/5d924b5a19ac0a31e61ab7f0ca670e70b197edf2))

## [1.1.3](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.2...1.1.3) (2026-05-29)


### Bug Fixes

* **web:** URL 查询参数使用 Uri.EscapeDataString 编码 ([6841f55](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/6841f55d43e219788e5559a03b174231b8d90b97))

## [1.1.2](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.1...1.1.2) (2026-05-28)


### Bug Fixes

* **ci:** 统一 .github 工作流配置 ([0ef733b](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/0ef733bdfc74e1473394c3ce0a3ffd86750a7a1c))

## [1.1.1](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.1.0...1.1.1) (2026-03-27)


### Bug Fixes

* **WebProtoBuff:** 移除条件编译并统一使用完全限定名 ([244c062](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/244c0625b00b4c965d43a9ddd9413f01d223bf96))

# [1.1.0](https://github.com/gameframex/com.gameframex.unity.web.protobuff/compare/1.0.0...1.1.0) (2026-02-12)


### Features

* **Web:** 添加网络消息调试日志 ([78680a8](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/78680a8975b724602e3c0fa503320b08bad84005))

# 1.0.0 (2025-12-23)


### Features

* **WebProtoBuff:** 添加 RequireComponent 属性以确保依赖组件存在 ([f1e6ded](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/f1e6dedcd630342c43feaeee91b716abf9ffc1c8))
* **WebProtoBuff:** 添加裁剪辅助类确保代码不被裁剪 ([da5142c](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/da5142c6ed8c241cb135fe55fe34bfa8821aec2e))
* 添加Web ProtoBuff组件支持HTTP请求和ProtoBuf序列化 ([1f990c7](https://github.com/gameframex/com.gameframex.unity.web.protobuff/commit/1f990c72e1b1e59c35d0a035403df57ca3c25ce9))

# Changelog

## [1.1.8](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.8) (2025-05-31)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.7...1.1.8)

## [1.1.7](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.7) (2025-05-30)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.6...1.1.7)

## [1.1.6](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.6) (2025-04-07)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.5...1.1.6)

## [1.1.5](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.5) (2025-01-20)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.3...1.1.5)

## [1.1.3](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.3) (2024-12-30)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.2...1.1.3)

## [1.1.2](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.2) (2024-12-27)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.1...1.1.2)

## [1.1.1](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.1) (2024-10-11)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.1.0...1.1.1)

## [1.1.0](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.1.0) (2024-09-10)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.0.6...1.1.0)

## [1.0.6](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.0.6) (2024-09-10)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.0.4...1.0.6)

## [1.0.4](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.0.4) (2024-09-10)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.0.5...1.0.4)

## [1.0.5](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.0.5) (2024-09-10)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.0.3...1.0.5)

## [1.0.3](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.0.3) (2024-09-10)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.0.2...1.0.3)

## [1.0.2](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.0.2) (2024-09-10)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/1.0.1...1.0.2)

## [1.0.1](https://github.com/GameFrameX/com.gameframex.unity.web/tree/1.0.1) (2024-05-20)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.web/compare/163a297eefa9ade04e6bdd245eb15ac27c7e3c27...1.0.1)



\* *This Changelog was automatically generated by [github_changelog_generator](https://github.com/github-changelog-generator/github-changelog-generator)*
