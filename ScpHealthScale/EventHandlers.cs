using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Linq;
using UnityEngine;

namespace ScpHealthScale
{
	class EventHandlers
	{
		internal void OnChangingRole(ChangingRoleEventArgs ev)
		{
			Timing.CallDelayed(0.3f, () =>
			{
				if (ev.Player.Role.Team == Team.SCP && ev.Player.Role != RoleType.Scp079)
				{
					int count = Player.Get(x => x.IsAlive && x.IsHuman).Count();
					if (count != 0)
					{
						ev.Player.Health = Mathf.Clamp(ev.Player.Health * (int)Math.Round(Plugin.singleton.Config.ScpHealthMultiplier * count, MidpointRounding.AwayFromZero), 0,
							Plugin.singleton.Config.ScpMaxHealth.ContainsKey(ev.Player.Role) ?
							Plugin.singleton.Config.ScpMaxHealth[ev.Player.Role] :
							int.MaxValue);
					}
				}
			});
		}
	}
}
