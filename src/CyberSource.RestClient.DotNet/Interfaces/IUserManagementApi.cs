using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserManagementApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>UmsV1UsersGet200Response</returns>
        UmsV1UsersGet200Response GetUsers(string organizationId = null, string userName = null,
            string permissionId = null, string roleId = null);

        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        ApiResponse<UmsV1UsersGet200Response> GetUsersWithHttpInfo(string organizationId = null, string userName = null,
            string permissionId = null, string roleId = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        Task<UmsV1UsersGet200Response> GetUsersAsync(string organizationId = null,
            string userName = null, string permissionId = null, string roleId = null);

        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        Task<ApiResponse<UmsV1UsersGet200Response>> GetUsersAsyncWithHttpInfo(
            string organizationId = null, string userName = null, string permissionId = null, string roleId = null);

        #endregion Asynchronous Operations
    }
}