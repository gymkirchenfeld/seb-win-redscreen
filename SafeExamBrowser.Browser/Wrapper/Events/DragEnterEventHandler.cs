﻿/*
 * Copyright (c) 2024 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using CefSharp;
using CefSharp.Enums;

namespace SafeExamBrowser.Browser.Wrapper.Events
{
	internal delegate void DragEnterEventHandler(IWebBrowser webBrowser, IBrowser browser, IDragData dragData, DragOperationsMask mask, GenericEventArgs args);
}