﻿/*
 * SPDX-FileCopyrightText: Copyright Corsinvest Srl
 * SPDX-License-Identifier: GPL-3.0-only
 */

using Corsinvest.ProxmoxVE.Api.Shared.Models.Common;
using Corsinvest.ProxmoxVE.Api.Shared.Utils;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Corsinvest.ProxmoxVE.Api.Shared.Models.Vm;

/// <summary>
/// Vm Qemu Status Current
/// </summary>
public class VmBaseStatusCurrent : IVmBase, INetIO, IDisk, IMemory, ICpu, IDiskIO
{
    /// <summary>
    /// Net in
    /// </summary>
    /// <value></value>
    [JsonProperty("netin")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long NetIn { get; set; }

    /// <summary>
    /// Net out
    /// </summary>
    /// <value></value>
    [JsonProperty("netout")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long NetOut { get; set; }

    /// <summary>
    /// Disk usage
    /// </summary>
    /// <value></value>
    [JsonProperty("disk")]
    [Display(Name = "Disk usage")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long DiskUsage { get; set; }

    /// <summary>
    /// Disk size
    /// </summary>
    /// <value></value>
    [JsonProperty("maxdisk")]
    [Display(Name = "Disk size")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long DiskSize { get; set; }

    /// <summary>
    /// Disk usage percentage
    /// </summary>
    /// <value></value>
    [Display(Name = "Disk usage %")]
    [DisplayFormat(DataFormatString = "{0:P1}")]
    public double DiskUsagePercentage { get; set; }

    /// <summary>
    /// Memory usage
    /// </summary>
    /// <value></value>
    [JsonProperty("mem")]
    [Display(Name = "Memory")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long MemoryUsage { get; set; }

    /// <summary>
    ///Memory size
    /// </summary>
    /// <value></value>
    [JsonProperty("maxmem")]
    [Display(Name = "Max Memory")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long MemorySize { get; set; }

    /// <summary>
    /// Memory info
    /// </summary>
    /// <value></value>
    [Display(Name = "Memory")]
    public string MemoryInfo { get; set; }

    /// <summary>
    /// Memory usage percentage
    /// </summary>
    /// <value></value>
    [Display(Name = "Memory Usage %")]
    [DisplayFormat(DataFormatString = "{0:P1}")]
    public double MemoryUsagePercentage { get; set; }

    /// <summary>
    /// Cpu usage
    /// </summary>
    /// <value></value>
    [Display(Name = "CPU Usage %")]
    [DisplayFormat(DataFormatString = "{0:P1}")]
    [JsonProperty("cpu")]
    public double CpuUsagePercentage { get; set; }

    /// <summary>
    /// Cpu size
    /// </summary>
    /// <value></value>
    [JsonProperty("cpus")]
    public long CpuSize { get; set; }

    /// <summary>
    /// Cpu info
    /// </summary>
    /// <value></value>
    [Display(Name = "Cpu")]
    public string CpuInfo { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Vm Id
    /// </summary>
    [JsonProperty("vmid")]
    public long VmId { get; set; }

    /// <summary>
    /// Disk read
    /// </summary>
    /// <value></value>
    [JsonProperty("diskread")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long DiskRead { get; set; }

    /// <summary>
    /// Disk write
    /// </summary>
    /// <value></value>
    [JsonProperty("diskwrite")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatBytes + "}")]
    public long DiskWrite { get; set; }

    /// <summary>
    /// Pid
    /// </summary>
    [JsonProperty("pid")]
    public long Pid { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }

    /// <summary>
    /// Status Is running
    /// </summary>
    /// <value></value>
    public bool IsRunning { get; set; }

    /// <summary>
    /// Status Is stopped
    /// </summary>
    /// <value></value>
    public bool IsStopped { get; set; }

    /// <summary>
    /// Status Is paused
    /// </summary>
    /// <value></value>
    public bool IsPaused { get; set; }

    /// <summary>
    /// Is template
    /// </summary>
    /// <value></value>
    [JsonProperty("template")]
    public bool IsTemplate { get; set; }

    /// <summary>
    /// Uptime
    /// </summary>
    /// <value></value>
    [JsonProperty("uptime")]
    [DisplayFormat(DataFormatString = "{0:" + FormatHelper.FormatUptimeUnixTime + "}")]
    public long Uptime { get; set; }

    /// <summary>
    /// Ha
    /// </summary>
    [JsonProperty("ha")]
    public HaInt Ha { get; set; }

    /// <summary>
    /// Ha
    /// </summary>
    public class HaInt
    {
        /// <summary>
        /// Managed
        /// </summary>
        [JsonProperty("managed")]
        public int Managed { get; set; }
    }

    /// <summary>
    /// Serialized Method
    /// </summary>
    protected void OnSerializedMethodBase()
    {
        ((IDisk)this).ImproveData();
        ((IMemory)this).ImproveData();
        ((ICpu)this).ImproveData();
        ((IVmBase)this).ImproveData(Status);
    }
}