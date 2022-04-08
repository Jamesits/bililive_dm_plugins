Some plugins for [Bilibili 弹幕姬](https://www.danmuji.org/).

# Plugin List

| Directory | Name | Description | Notes |
| --------- | ---- | ----------- | ----- |
| bililive_dm_plugin_tts | TTS | Reads messages aload in a robotic sound |  |

# Usage

0. Close Bilibili 弹幕姬
0. Copy the release DLLs to the plugins directory (`%USERPROFILE%\Documents\弹幕姬\Plugins`)
0. Open Bilibili 弹幕姬
0. Go to Plugins tab -> right click the plugin -> Enable Plugin

# Licensing

This project is free and open source under *[the MIT License](LICENSE)*. If you want to support the development of this
project, use the sponsor button on the top right of the page.

# Developer Notes

## Building

Requirements:
- Visual Studio 2019 (Community or higher)
- C# development packages
- .Net Framework 4.6.1

Building:
1. Clone this repo
1. Download [the SDK](https://soft.ceve-market.org/bilibili_dm/sdk.7z) and extract everything into the `sdk` directory
1. Open `bililive_dm_plugins.sln` in VS2019
1. Build the solution

Installing:
Copy the plugin DLLs (e.g. `bin\Release\bililive_dm_plugin_tts.dll`) to the plugin directory
(`%USERPROFILE%\Documents\弹幕姬\Plugins`), then restart the main program.

## Debugging

In cases where the plugin is causing the main program to crash, use the following method to set up a debugging environment.

Requirements:
- Visual Studio 2019 (Community or higher)
- C# development packages
- C++ development packages
- UWP development packages
- .Net Framework 4.6.1
- Windows SDK (10.0.16299.0)
- Platform Toolset (v141 and v142)

Building:
Clone either [the upstream version](https://github.com/copyliu/bililive_dm) or [my fork](https://github.com/Jamesits/bililive_dm),
and build in the VS2019 IDE.

Debugging:
Directly debug the main program in the VS2019 IDE. If your plugins are built in a debug configuration, the symbols will be loaded automatically.

Notes:
- My fork fixed some building issues in newer toolset versions
- [Official plugin development documentation](https://github.com/copyliu/bililive_dm/wiki/%E5%BC%B9%E5%B9%95%E5%A7%AC%E6%8F%92%E4%BB%B6%E5%BC%80%E5%8F%91)
