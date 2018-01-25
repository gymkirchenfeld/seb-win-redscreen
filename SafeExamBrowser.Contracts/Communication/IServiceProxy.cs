﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Contracts.Communication
{
	public interface IServiceProxy
	{
		/// <summary>
		/// Instructs the proxy to ignore all operations or simulate a connection, where applicable. To be set e.g. when the service
		/// policy is optional and the service is not available.
		/// </summary>
		bool Ignore { set; }

		/// <summary>
		/// Tries to connect to the service host.
		/// </summary>
		bool Connect();

		/// <summary>
		/// Disconnects from the service host.
		/// </summary>
		void Disconnect();
	}
}
