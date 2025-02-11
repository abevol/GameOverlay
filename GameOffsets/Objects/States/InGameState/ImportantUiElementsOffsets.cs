﻿namespace GameOffsets.Objects.States.InGameState
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    ///     All offsets over here are UiElements.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ImportantUiElementsOffsets
    {
        [FieldOffset(0x688)] public IntPtr MapParentPtr;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MapParentStruct
    {
        [FieldOffset(0x278)] public IntPtr LargeMapPtr;
        [FieldOffset(0x280)] public IntPtr MiniMapPtr;
    }
}
