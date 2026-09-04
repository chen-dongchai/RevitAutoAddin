# RevitAutoAddin

一个用于快速生成 Revit 插件 .addin 配置文件的 WPF 桌面工具。

## 功能

- 输入插件名称、类名、GUID
- 选择 Revit 版本
- 一键生成 `.addin` 文件

## 使用场景

在开发 Revit 插件时，手动创建 .addin 文件需要复制模板、替换占位符、保存文件。这个工具将整个过程简化为填写表单 + 点击按钮。

## 技术栈

- C# / .NET Framework 4.8
- WPF (MVVM模式)
- XAML

## 适用 Revit 版本

2021-2025

## 开发背景

独立学习 WPF 的小项目，也是个人工具链的一部分。代码约 50 行，用于简化 Revit 插件开发中的重复性工作。
