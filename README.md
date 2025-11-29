<!--markdownlint-disable MD001 MD033 MD041 MD051-->

<div align="center">

# <image src="ClassIsland/Assets/DubiIsland-AppLogo.png" height="72" width="72"/> <br/> DubiIsland

**延续 ClassIsland 1.7 的火种** | 打造我心中更完美的 ClassIsland

![Banner](https://res.classisland.tech/banners/banner-v2-1.webp)

[![Stars](https://img.shields.io/github/stars/ClassIsland/ClassIsland?label=Stars)](https://github.com/ClassIsland/ClassIsland)
[![正式版 Release](https://img.shields.io/github/v/release/ClassIsland/ClassIsland?style=flat-square&color=%233fb950&label=正式版)](https://github.com/ClassIsland/ClassIsland/releases/latest)
[![测试版 Release](https://img.shields.io/github/v/release/ClassIsland/ClassIsland?include_prereleases&style=flat-square&label=测试版)](https://github.com/ClassIsland/ClassIsland/releases/)
[![下载量](https://img.shields.io/github/downloads/ClassIsland/ClassIsland/total?style=social&label=下载量&logo=github)](https://github.com/ClassIsland/ClassIsland/releases/latest)<br/>
![.NET 版本](https://img.shields.io/badge/.NET-8-512bd4?style=flat-square)
![GitHub Repo size](https://img.shields.io/github/repo-size/ClassIsland/ClassIsland?style=flat-square&color=3cb371)
[![GitHub Repo Languages](https://img.shields.io/github/languages/top/ClassIsland/ClassIsland?style=flat-square)](https://github.com/ClassIsland/ClassIsland/search?l=c%23)

ClassIsland 是一款适用于班级多媒体屏幕的课表信息显示工具，可以在 Windows 屏幕上显示各种信息。<br/>
DubiIsland 基于 ClassIsland 1.7 分支版本打造，致力于创造一个更易用的且支持 Windows 7 系统的桌面课表体验<br/>
本应用的名字灵感源于 iOS 灵动岛（Dynamic Island）功能。

#### 💬[Classlsland QQ 频道](https://pd.qq.com/s/grr6qwqwj) | [Classlsland QQ 群组](https://qm.qq.com/q/4NsDQKiAuQ) | [InkCanvastland CCE 自留地](https://qm.qq.com/q/3SpITDd1jq)

#### [🌐 官方网站](https://classisland.tech/) | [🚀 软件下载](https://classisland.tech/download)｜[📚 项目文档](https://docs.classisland.tech)｜[🗳 功能投票](https://github.com/ClassIsland/voting/discussions?discussions_q=is%3Aopen+sort%3Atop) 

</div>

## 功能

> [!TIP]
>
> 您可以点击下方链接或查看 [ClassIsland 文档](https://docs.classisland.tech) 了解更多。

### 课表信息显示

- [x] 显示当天的课表、当前进行课程的信息
- [x] 在上下课等重要时间点发出 [提醒](https://docs.classisland.tech/app/notifications)，自选搭配音效、强调特效、语音和置顶效果的 [强调提醒](https://docs.classisland.tech/app/notifications#强调提醒)
- [x] 自选课表隐藏条件、临时隐藏与鼠标穿透，不影响授课

### 课表编辑与管理

- [x] 简洁直观的 [课表编辑工具](https://docs.classisland.tech/app/classplan)
- [x] 从 Excel 表格、[CSES](https://github.com/SmartTeachCN/CSES) 或其他软件 [导入课表](https://docs.classisland.tech/app/profile/#%E4%BB%8E%E8%A1%A8%E6%A0%BC%E5%AF%BC%E5%85%A5)
- [x] 将课表信息导出到 Excel 表格
- [x] 多周轮换、快速录入时间表、自定义设置
- [x] 单日/跨天临时换课
- [x] 提前预定要临时启用的课表

### 自定义

- [x] 通过 [组件](https://docs.classisland.tech/app/basic#组件)（日期、时间、天气简报、倒计日等）自定义显示的内容。支持多行显示组件、组件轮播和组件滚动
- [x] 通过 [插件](https://docs.classisland.tech/app/basic#组件) 扩展应用功能，高度自定义你的 ClassIsland
- [x] 通过主题系统高度定制应用主界面外观

### 其它功能

- [x] 通过[自动化](https://docs.classisland.tech/app/automation.html)在特定事件发生时/特定时间自动执行某些操作（如显示提醒、打开应用/文件/网页等），提高教学效率
- [x] 显示当前的[天气](https://docs.classisland.tech/app/advanced#天气)信息、降水提示、6 小时/3 天天气预报和极端天气预警等信息，支持根据定位获取天气信息
- [x] 自动同步软件时间、手动对齐铃声
- [x] 使用密码等认证方式保护应用设置和课表配置
- [x] 丝滑、流畅的过渡动画
- [x] 自动获取与系统配色搭配的主题色
- [x] 自动软件更新
- [ ] [集控管理](https://docs.classisland.tech/management)_（即将发布）_
- [ ] ……

### DubiIsland 的相关优化

- [x] 迁移到 .NET6 并进一步优化在 Windows 7 等老旧操作系统上的适配。
- [ ] 将部分 ClassIsland 2.0 的新组件迁移到该版本中
- [ ] 迁移 ClassIsland 2.0 的 Fluent 皮肤到该版本中并优化
- [ ] 配置编辑器的整体 UI/UX 优化和重构
- [ ] 开发基于 Direct3D 的高性能桌面课表窗口渲染器（仅支持新系统）
- [ ] ……

## 开始使用

**首先，请确保您的设备满足以下推荐需求：**

- Windows 10 及以上版本的系统 **或者是 Windows 7 SP1 及以上版本的系统（未经过广泛测试）**

ClassIsland 与部分窗口美化工具（特别是如 Mica For Everyone 这类修改窗口材质的工具）**不兼容**，因为我们使用了 DWM Composition 特性来实现高性能的窗口透明。与这些工具同时使用 ClassIsland 时请将 ClassIsland 添加到这些工具的排除列表中。

对于普通用户，可以在以下渠道下载到本软件，请根据自身网络环境选择合适的渠道。

- [GitHub Releases](https://github.com/ClassIsland/ClassIsland/releases/)

下载完成后，将软件压缩包解压到一个**独立的文件夹（运行路径不能有中文）**，运行软件即可开始使用。解压时请不要解压到网盘同步文件夹、【下载】文件夹中，否则可能会出现**文件无法读写、文件丢失**等问题。

## 获取帮助＆加入社区

您可以访问以下页面来**获取帮助**：

- [ClassIsland 帮助文档](https://docs.classisland.tech/app)

您也可以加入这些社区**寻求帮助**：

[![GitHub Issues](https://img.shields.io/github/issues-search/ClassIsland/ClassIsland?query=is%3Aopen&style=flat-square&logo=github&label=Issues&color=%233fb950)](https://github.com/ClassIsland/ClassIsland/issues)
[![GitHub Discussions](https://img.shields.io/github/discussions/ClassIsland/ClassIsland?style=flat-square&logo=Github&label=Discussions)](https://github.com/ClassIsland/ClassIsland/discussions)
[![加入 QQ 频道](https://img.shields.io/badge/QQ_%E9%A2%91%E9%81%93-classisland-%230066cc?style=flat-square&logo=TencentQQ)](https://pd.qq.com/s/scb3wzia)
[![加入 QQ 群](https://img.shields.io/badge/QQ_%E7%BE%A4-958840932-%230066cc?style=flat-square&logo=TencentQQ)](https://qm.qq.com/q/4NsDQKiAuQ)

如果您确定您遇到的问题是一个 **Bug**，或者您要提出一项**新的功能**，请[提交 Issue](https://github.com/ClassIsland/ClassIsland/issues/new/choose)。

## 开发

![Alt](https://repobeats.axiom.co/api/embed/ace0a0609166a47b16a58bb7d2d0d5e20968d4d1.svg "Repobeats analytics image")

本项目目前开发状态：

| 分支 | 开发状态 | 状态 |
| --- | --- | --- |
| [`main`](https://github.com/segf4ultk1nger/DubiIsland/tree/master) | 正在此分支上维护版本 [1.8 - SteinsGate](https://github.com/ClassIsland/ClassIsland/milestone/8)。| [![Build](https://github.com/ClassIsland/ClassIsland/actions/workflows/build_release.yml/badge.svg?branch=master&style=flat_square)](https://github.com/ClassIsland/ClassIsland/actions/workflows/build_release.yml) [![CodeFactor](https://www.codefactor.io/repository/github/classisland/classisland/badge/master)](https://www.codefactor.io/repository/github/classisland/classisland/overview/master) |

要在本地编译应用，请参考文档[配置 ClassIsland 本体开发环境](https://docs.classisland.tech/dev/get-started/devlopment.html)。

如果您有意愿为 ClassIsland 做出代码贡献，请先阅读 [贡献指南](CONTRIBUTING.md) 来了解如何为 ClassIsland 做代码贡献。我们欢迎想要为本应用实现新功能或进行改进的同学提交 [Pull Request](https://github.com/ClassIsland/ClassIsland/pulls)。

## 致谢

**DubiIsland 项目由 segf4ultk1nger 和 Xavo Industries 联合出品。**

本项目受到 [DuguSand/class_form](https://github.com/DuguSand/class_form) 的启发而开发。

感谢以下同学为本项目为本项目的开发提供支持：

<a href="https://github.com/ClassIsland/ClassIsland/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ClassIsland/ClassIsland" />
</a>

<br/>

本项目使用了[这些第三方库和框架](./doc/Dependencies.md)。

感谢 [JetBrains](https://www.jetbrains.com.cn/) 为本项目的开发人员提供的[开源开发许可证](https://www.jetbrains.com.cn/community/opensource/)。

详细的致谢信息请前往[【应用设置】->【关于 ClassIsland】](classisland://app/settings/about)界面中查看。

## 赞助商 / Sponsors

感谢以下赞助商对本项目的支持。

<table>
  <tr>
    <td></td>
    <td>
    Xavo Industries 2024-2025
    </td>
  </tr> 
</table>

## 许可证

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FHelloWRC%2FClassIsland.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2FHelloWRC%2FClassIsland?ref=badge_shield&style=flat-square)

本项目中的以下项目基于 GNU Lesser General Public License v3.0 获得许可：

- [ClassIsland.PluginSdk](ClassIsland.PluginSdk)
- [ClassIsland.Core](ClassIsland.Core)
- [ClassIsland.Shared.Ipc](ClassIsland.Shared.Ipc)
- [ClassIsland.Shared](ClassIsland.Shared)

本项目的其余部分（包括但不限于应用本体）基于 [GNU General Public License v3.0](LICENSE.txt) 获得许可。