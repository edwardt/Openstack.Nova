namespace Openstack.Nova
{
	using System;

	enum Version 
	{
		current = 1.1
	}

	public struct ApiInfo
	{
		const int Version = Version.current;
		const string Resource = "NovaCompute";
	}
}

