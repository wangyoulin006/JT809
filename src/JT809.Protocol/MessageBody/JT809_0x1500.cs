﻿using JT809.Protocol.Enums;
using JT809.Protocol.Extensions;

namespace JT809.Protocol.MessageBody
{
    /// <summary>
    /// 主链路车辆监管消息
    /// <para>链路类型:主链路</para>
    /// <para>消息方向:下级平台往上级平台</para>
    /// <para>业务数据类型标识:UP_CTRL_MSG</para>
    /// <para>描述:下级平台向上级平台发送车辆监管业务</para>
    /// </summary>
    public class JT809_0x1500: JT809ExchangeMessageBodies
    {
        public override ushort MsgId => JT809BusinessType.主链路车辆监管消息.ToUInt16Value();
        public override string Description => "主链路车辆监管消息";
        public override JT809_LinkType LinkType => JT809_LinkType.main;
    }
}
