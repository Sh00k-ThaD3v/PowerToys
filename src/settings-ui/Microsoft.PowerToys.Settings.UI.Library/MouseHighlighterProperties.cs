﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class MouseHighlighterProperties
    {
        [JsonPropertyName("activation_shortcut")]
        public HotkeySettings ActivationShortcut { get; set; }

        public MouseHighlighterProperties()
        {
            ActivationShortcut = new HotkeySettings(true, false, false, true, 0x48);
        }
    }
}
