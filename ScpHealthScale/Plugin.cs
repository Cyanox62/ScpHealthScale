using Exiled.API.Features;

namespace ScpHealthScale
{
	public class Plugin : Plugin<Config>
	{
		internal static Plugin singleton;

		private EventHandlers ev;

		public override void OnEnabled()
		{
			base.OnEnabled();

			singleton = this;

			ev = new EventHandlers();
			Exiled.Events.Handlers.Player.ChangingRole += ev.OnChangingRole;
		}

		public override void OnDisabled()
		{
			base.OnDisabled();

			Exiled.Events.Handlers.Player.ChangingRole -= ev.OnChangingRole;
			ev = null;
		}

		public override string Author => "Cyanox";
	}
}
