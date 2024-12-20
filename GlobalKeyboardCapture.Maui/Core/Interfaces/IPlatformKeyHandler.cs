﻿namespace GlobalKeyboardCapture.Maui.Core.Interfaces;
public interface IPlatformKeyHandler
{
    void Initialize(object platformView);
    void ConfigureHandler(Action<Models.KeyEventArgs> onKeyPressed);
    void Cleanup();
}
