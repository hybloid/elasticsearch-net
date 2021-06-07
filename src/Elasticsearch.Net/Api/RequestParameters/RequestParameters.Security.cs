// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.SecurityApi
{
	///<summary>Request options for Authenticate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-authenticate.html</para></summary>
	public class AuthenticateRequestParameters : RequestParameters<AuthenticateRequestParameters>
	{
	}

	///<summary>Request options for ChangePassword <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-change-password.html</para></summary>
	public class ChangePasswordRequestParameters : RequestParameters<ChangePasswordRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for ClearApiKeyCache <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-api-key-cache.html</para></summary>
	public class ClearApiKeyCacheRequestParameters : RequestParameters<ClearApiKeyCacheRequestParameters>
	{
	}

	///<summary>Request options for ClearCachedPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-privilege-cache.html</para></summary>
	public class ClearCachedPrivilegesRequestParameters : RequestParameters<ClearCachedPrivilegesRequestParameters>
	{
	}

	///<summary>Request options for ClearCachedRealms <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-cache.html</para></summary>
	public class ClearCachedRealmsRequestParameters : RequestParameters<ClearCachedRealmsRequestParameters>
	{
		///<summary>Comma-separated list of usernames to clear from the cache</summary>
		public string[] Usernames
		{
			get => Q<string[]>("usernames");
			set => Q("usernames", value);
		}
	}

	///<summary>Request options for ClearCachedRoles <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-role-cache.html</para></summary>
	public class ClearCachedRolesRequestParameters : RequestParameters<ClearCachedRolesRequestParameters>
	{
	}

	///<summary>Request options for ClearCachedServiceTokens <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-service-token-caches.html</para></summary>
	public class ClearCachedServiceTokensRequestParameters : RequestParameters<ClearCachedServiceTokensRequestParameters>
	{
	}

	///<summary>Request options for CreateApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-create-api-key.html</para></summary>
	public class CreateApiKeyRequestParameters : RequestParameters<CreateApiKeyRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for CreateServiceToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-create-service-token.html</para></summary>
	public class CreateServiceTokenRequestParameters : RequestParameters<CreateServiceTokenRequestParameters>
	{
		///<summary>
		/// If `true` then refresh the affected shards to make this operation visible to search, if `wait_for` (the default) then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeletePrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-privilege.html</para></summary>
	public class DeletePrivilegesRequestParameters : RequestParameters<DeletePrivilegesRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-role.html</para></summary>
	public class DeleteRoleRequestParameters : RequestParameters<DeleteRoleRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-role-mapping.html</para></summary>
	public class DeleteRoleMappingRequestParameters : RequestParameters<DeleteRoleMappingRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteServiceToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-service-token.html</para></summary>
	public class DeleteServiceTokenRequestParameters : RequestParameters<DeleteServiceTokenRequestParameters>
	{
		///<summary>
		/// If `true` then refresh the affected shards to make this operation visible to search, if `wait_for` (the default) then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-user.html</para></summary>
	public class DeleteUserRequestParameters : RequestParameters<DeleteUserRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DisableUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-disable-user.html</para></summary>
	public class DisableUserRequestParameters : RequestParameters<DisableUserRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for EnableUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-enable-user.html</para></summary>
	public class EnableUserRequestParameters : RequestParameters<EnableUserRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for EnrollNode <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/security-api-node-enrollment.html</para></summary>
	public class EnrollNodeRequestParameters : RequestParameters<EnrollNodeRequestParameters>
	{
	}

	///<summary>Request options for GetApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-api-key.html</para></summary>
	public class GetApiKeyRequestParameters : RequestParameters<GetApiKeyRequestParameters>
	{
		///<summary>API key id of the API key to be retrieved</summary>
		public string Id
		{
			get => Q<string>("id");
			set => Q("id", value);
		}

		///<summary>API key name of the API key to be retrieved</summary>
		public string Name
		{
			get => Q<string>("name");
			set => Q("name", value);
		}

		///<summary>flag to query API keys owned by the currently authenticated user</summary>
		public bool? Owner
		{
			get => Q<bool? >("owner");
			set => Q("owner", value);
		}

		///<summary>realm name of the user who created this API key to be retrieved</summary>
		public string RealmName
		{
			get => Q<string>("realm_name");
			set => Q("realm_name", value);
		}

		///<summary>user name of the user who created this API key to be retrieved</summary>
		public string Username
		{
			get => Q<string>("username");
			set => Q("username", value);
		}
	}

	///<summary>Request options for GetBuiltinPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-builtin-privileges.html</para></summary>
	public class GetBuiltinPrivilegesRequestParameters : RequestParameters<GetBuiltinPrivilegesRequestParameters>
	{
	}

	///<summary>Request options for GetPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-privileges.html</para></summary>
	public class GetPrivilegesRequestParameters : RequestParameters<GetPrivilegesRequestParameters>
	{
	}

	///<summary>Request options for GetRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-role.html</para></summary>
	public class GetRoleRequestParameters : RequestParameters<GetRoleRequestParameters>
	{
	}

	///<summary>Request options for GetRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-role-mapping.html</para></summary>
	public class GetRoleMappingRequestParameters : RequestParameters<GetRoleMappingRequestParameters>
	{
	}

	///<summary>Request options for GetServiceAccounts <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-service-accounts.html</para></summary>
	public class GetServiceAccountsRequestParameters : RequestParameters<GetServiceAccountsRequestParameters>
	{
	}

	///<summary>Request options for GetServiceCredentials <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-service-credentials.html</para></summary>
	public class GetServiceCredentialsRequestParameters : RequestParameters<GetServiceCredentialsRequestParameters>
	{
	}

	///<summary>Request options for GetUserAccessToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-token.html</para></summary>
	public class GetUserAccessTokenRequestParameters : RequestParameters<GetUserAccessTokenRequestParameters>
	{
	}

	///<summary>Request options for GetUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-user.html</para></summary>
	public class GetUserRequestParameters : RequestParameters<GetUserRequestParameters>
	{
	}

	///<summary>Request options for GetUserPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-privileges.html</para></summary>
	public class GetUserPrivilegesRequestParameters : RequestParameters<GetUserPrivilegesRequestParameters>
	{
	}

	///<summary>Request options for GrantApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-grant-api-key.html</para></summary>
	public class GrantApiKeyRequestParameters : RequestParameters<GrantApiKeyRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for HasPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-has-privileges.html</para></summary>
	public class HasPrivilegesRequestParameters : RequestParameters<HasPrivilegesRequestParameters>
	{
	}

	///<summary>Request options for InvalidateApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-invalidate-api-key.html</para></summary>
	public class InvalidateApiKeyRequestParameters : RequestParameters<InvalidateApiKeyRequestParameters>
	{
	}

	///<summary>Request options for InvalidateUserAccessToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-invalidate-token.html</para></summary>
	public class InvalidateUserAccessTokenRequestParameters : RequestParameters<InvalidateUserAccessTokenRequestParameters>
	{
	}

	///<summary>Request options for PutPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-privileges.html</para></summary>
	public class PutPrivilegesRequestParameters : RequestParameters<PutPrivilegesRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for PutRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-role.html</para></summary>
	public class PutRoleRequestParameters : RequestParameters<PutRoleRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for PutRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-role-mapping.html</para></summary>
	public class PutRoleMappingRequestParameters : RequestParameters<PutRoleMappingRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for PutUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-user.html</para></summary>
	public class PutUserRequestParameters : RequestParameters<PutUserRequestParameters>
	{
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for SamlCompleteLogout <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-saml-complete-logout.html</para></summary>
	public class SamlCompleteLogoutRequestParameters : RequestParameters<SamlCompleteLogoutRequestParameters>
	{
	}

	///<summary>Request options for GetCertificates <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-ssl.html</para></summary>
	public class GetCertificatesRequestParameters : RequestParameters<GetCertificatesRequestParameters>
	{
	}
}