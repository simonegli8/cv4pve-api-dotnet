﻿/*
 * SPDX-FileCopyrightText: 2022 Daniele Corsini <daniele.corsini@corsinvest.it>
 * SPDX-FileCopyrightText: Copyright Corsinvest Srl
 * SPDX-License-Identifier: GPL-3.0-only
 */

using Newtonsoft.Json;

namespace Corsinvest.ProxmoxVE.Api.Shared.Models.Cluster
{
    /// <summary>
    /// Cluster options
    /// </summary>
    public class ClusterOptions
    {
        /// <summary>
        /// Keyboard
        /// </summary>
        [JsonProperty("keyboard")]
        public string Keyboard { get; set; }

        /// <summary>
        /// Migration
        /// </summary>
        [JsonProperty("migration")]
        public MigrationInt Migration { get; set; }

        /// <summary>
        /// Migration
        /// </summary>
        public class MigrationInt
        {
            /// <summary>
            /// Network
            /// </summary>
            [JsonProperty("network")]
            public string Network { get; set; }

            /// <summary>
            /// Type
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }
        }
    }
}