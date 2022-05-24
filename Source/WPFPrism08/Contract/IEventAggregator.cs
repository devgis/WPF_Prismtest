using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Events;

namespace Contract
{
    public interface IEventAggregator
    {
        /// <summary>
        /// 获取事件类型的一个实例
        /// </summary>
        /// <typeparam name="TEventType">要获取实例的事件类型</typeparam>
        /// <returns>事件类型<typeparamref name="TEventType"/>的一个实例.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        TEventType GetEvent<TEventType>() where TEventType : EventBase;
    }
}
