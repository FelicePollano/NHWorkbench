namespace Effectus.Infrastructure
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;

    using NHibernate.Tool.WorkBench.Core;
    using System.Windows.Forms;

	public class EventPublisher
	{
		private readonly static IDictionary<Type, List<Action<object>>> Subscribers 
			= new Dictionary<Type, List<Action<object>>>();

		public static void Publish<T>(T eventToPublish, IPresenter publishedBy)
		{
			List<Action<object>> actions;
			lock (Subscribers)
			{
				if (Subscribers.TryGetValue(typeof(T), out actions) == false)
				{
					return;
				}
			}
			foreach (var action in actions)
			{
				if (action.Target == publishedBy)
					continue;
				action(eventToPublish);
			}
		}

		public static void Register<T>(Action<T> action)
		{
			Debug.Assert(action.Target is IPresenter);
			lock(Subscribers)
			{
				List<Action<object>> value;
				if(Subscribers.TryGetValue(typeof(T), out value)==false)
				{
					Subscribers[typeof (T)] = value = new List<Action<object>>();
				}
				
				Action<object> item = o =>
				{
				    action((T) o);
				};
				((IPresenter) action.Target).Disposed += (object _,EventArgs __)=> Unregister<T>(item);
				value.Add(item);
			}
		}

		private static void Unregister<T>(Action<object> action)
		{
			lock(Subscribers)
			{
				List<Action<object>> value;
				if (Subscribers.TryGetValue(typeof(T), out value) == false)
				{
					return;
				}
				value.Remove(action);
			}
		}
	}
}