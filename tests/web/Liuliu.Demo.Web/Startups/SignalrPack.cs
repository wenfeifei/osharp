// -----------------------------------------------------------------------
//  <copyright file="SignalrPack.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor></last-editor>
//  <last-date>2018-07-26 12:15</last-date>
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.SignalR;
using OSharp.AspNetCore.SignalR;
using System;
using System.ComponentModel;

using Microsoft.AspNetCore.Routing;


namespace Liuliu.Demo.Web.Startups
{
    /// <summary>
    /// SignalR模块
    /// </summary>
    [Description("SignalR模块")]
    public class SignalRPack : SignalRPackBase
    {
        /// <summary>
        /// 重写以获取Hub终结点路由创建委托
        /// </summary>
        /// <param name="serviceProvider">服务提供者</param>
        /// <returns></returns>
        protected override Action<IEndpointRouteBuilder> GetEndpointRouteBuilderAction(IServiceProvider serviceProvider)
        {
            return new Action<IEndpointRouteBuilder>(endpoints =>
            {
                // 在这实现Hub的路由映射
                // 例如：endpoints.MapHub<ChatHub>();
            });
        }
    }
}