using System;

namespace Openstack.Nova.Client.Console
{
	public enum RuntimeStates
	{
		Accept,
		Ready,
		Executing,
		Timeout,
		Abort,
		Aborting,
		Dead
	}
}

