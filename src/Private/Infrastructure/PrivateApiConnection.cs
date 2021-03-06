﻿using System.Net;
using System.Threading.Tasks;
using FairlayDotNetClient.Private.Requests;
using FairlayDotNetClient.Private.Responses;

namespace FairlayDotNetClient.Private.Infrastructure
{
	public interface PrivateApiConnection
	{
		void SetEndpoint(IPEndPoint endPoint);
		Task<PrivateApiResponse> DoApiRequest(SignedPrivateApiRequest request);
	}
}