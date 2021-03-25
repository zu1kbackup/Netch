using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;
using Netch.Forms;
using Netch.Models;
using Netch.Services;

namespace Netch
{
    public static class Global
    {
        /// <summary>
        ///     用于读取和写入的配置
        /// </summary>
        public static Setting Settings = new();

        /// <summary>
        ///     用于存储模式
        /// </summary>
        public static readonly List<Mode> Modes = new();

        /// <summary>
        ///     主窗体的静态实例
        /// </summary>
        public static MainForm MainForm => DI.GetService<MainForm>();

        public static JsonSerializerOptions NewDefaultJsonSerializerOptions => new()
        {
            WriteIndented = true,
            IgnoreNullValues = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static readonly string NetchDir = Application.StartupPath;
        public static readonly string NetchExecutable = Application.ExecutablePath;
    }
}