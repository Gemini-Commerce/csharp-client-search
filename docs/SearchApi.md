# search.Api.SearchApi

All URIs are relative to *https://search.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SearchConfiguration**](SearchApi.md#searchconfiguration) | **POST** /search.Search/Configuration | Indexes configuration |
| [**SearchDelete**](SearchApi.md#searchdelete) | **POST** /search.Search/Delete | Delete Indexes |
| [**SearchInsertOrReplace**](SearchApi.md#searchinsertorreplace) | **POST** /search.Search/InsertOrReplace | Insert or replace documents to different elasticsearch indexes |
| [**SearchMSearch**](SearchApi.md#searchmsearch) | **POST** /search.Search/MSearch | Send queries to different elasticsearch indexes |
| [**SearchUpdate**](SearchApi.md#searchupdate) | **POST** /search.Search/Update | Update documents to different elasticsearch indexes |

<a id="searchconfiguration"></a>
# **SearchConfiguration**
> Object SearchConfiguration (SearchConfigRequest body)

Indexes configuration

Create or update indexes by a passed configuration schema

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using search.Api;
using search.Client;
using search.Model;

namespace Example
{
    public class SearchConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://search.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: geminiAuthorization
            config.AddApiKey("X-Gem-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Gem-Token", "Bearer");

            var apiInstance = new SearchApi(config);
            var body = new SearchConfigRequest(); // SearchConfigRequest | 

            try
            {
                // Indexes configuration
                Object result = apiInstance.SearchConfiguration(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Indexes configuration
    ApiResponse<Object> response = apiInstance.SearchConfigurationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SearchConfigRequest**](SearchConfigRequest.md) |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [geminiAuthorization](../README.md#geminiAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchdelete"></a>
# **SearchDelete**
> SearchDeleteResponse SearchDelete (SearchDeleteRequest body)

Delete Indexes

Delete indexes from ElasticSearch and Cassandra configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using search.Api;
using search.Client;
using search.Model;

namespace Example
{
    public class SearchDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://search.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: geminiAuthorization
            config.AddApiKey("X-Gem-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Gem-Token", "Bearer");

            var apiInstance = new SearchApi(config);
            var body = new SearchDeleteRequest(); // SearchDeleteRequest | 

            try
            {
                // Delete Indexes
                SearchDeleteResponse result = apiInstance.SearchDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Indexes
    ApiResponse<SearchDeleteResponse> response = apiInstance.SearchDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SearchDeleteRequest**](SearchDeleteRequest.md) |  |  |

### Return type

[**SearchDeleteResponse**](SearchDeleteResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [geminiAuthorization](../README.md#geminiAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchinsertorreplace"></a>
# **SearchInsertOrReplace**
> SearchWriteResponse SearchInsertOrReplace (SearchWriteRequest body)

Insert or replace documents to different elasticsearch indexes

Insert or replace a document or more in a specified ElasticSearch index of a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using search.Api;
using search.Client;
using search.Model;

namespace Example
{
    public class SearchInsertOrReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://search.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: geminiAuthorization
            config.AddApiKey("X-Gem-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Gem-Token", "Bearer");

            var apiInstance = new SearchApi(config);
            var body = new SearchWriteRequest(); // SearchWriteRequest | 

            try
            {
                // Insert or replace documents to different elasticsearch indexes
                SearchWriteResponse result = apiInstance.SearchInsertOrReplace(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchInsertOrReplace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchInsertOrReplaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Insert or replace documents to different elasticsearch indexes
    ApiResponse<SearchWriteResponse> response = apiInstance.SearchInsertOrReplaceWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchInsertOrReplaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SearchWriteRequest**](SearchWriteRequest.md) |  |  |

### Return type

[**SearchWriteResponse**](SearchWriteResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [geminiAuthorization](../README.md#geminiAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchmsearch"></a>
# **SearchMSearch**
> SearchQueryResponse SearchMSearch (SearchQueryRequest body)

Send queries to different elasticsearch indexes

MSearch promises to send a list of queries to elasticsearch to be executed on different indexes, it can also be used as an autocomplete by adding the corresponding TYPE

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using search.Api;
using search.Client;
using search.Model;

namespace Example
{
    public class SearchMSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://search.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: geminiAuthorization
            config.AddApiKey("X-Gem-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Gem-Token", "Bearer");

            var apiInstance = new SearchApi(config);
            var body = new SearchQueryRequest(); // SearchQueryRequest | 

            try
            {
                // Send queries to different elasticsearch indexes
                SearchQueryResponse result = apiInstance.SearchMSearch(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchMSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchMSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send queries to different elasticsearch indexes
    ApiResponse<SearchQueryResponse> response = apiInstance.SearchMSearchWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchMSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SearchQueryRequest**](SearchQueryRequest.md) |  |  |

### Return type

[**SearchQueryResponse**](SearchQueryResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [geminiAuthorization](../README.md#geminiAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchupdate"></a>
# **SearchUpdate**
> SearchWriteResponse SearchUpdate (SearchWriteRequest body)

Update documents to different elasticsearch indexes

Update a document or more in a specified ElasticSearch index of a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using search.Api;
using search.Client;
using search.Model;

namespace Example
{
    public class SearchUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://search.api.gogemini.io";
            // Configure API key authorization: standardAuthorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: geminiAuthorization
            config.AddApiKey("X-Gem-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Gem-Token", "Bearer");

            var apiInstance = new SearchApi(config);
            var body = new SearchWriteRequest(); // SearchWriteRequest | 

            try
            {
                // Update documents to different elasticsearch indexes
                SearchWriteResponse result = apiInstance.SearchUpdate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update documents to different elasticsearch indexes
    ApiResponse<SearchWriteResponse> response = apiInstance.SearchUpdateWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SearchWriteRequest**](SearchWriteRequest.md) |  |  |

### Return type

[**SearchWriteResponse**](SearchWriteResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization), [geminiAuthorization](../README.md#geminiAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

