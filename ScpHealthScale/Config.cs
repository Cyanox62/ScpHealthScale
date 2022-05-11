using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace ScpHealthScale
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;

		[Description("Determines the health multiplier per human player.")]
		public float ScpHealthMultiplier { get; set; } = 1f;

		[Description("Determines the max amount of health each SCP can have with the multiplier.")]
		public Dictionary<RoleType, int> ScpMaxHealth { get; set; } = new Dictionary<RoleType, int>();
	}
}
