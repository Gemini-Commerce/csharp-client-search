# # SearchResult
contains the search results, aggregations and paging information

## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index**| **string** | index where the data were extrapolated  |
**Params**| [**SearchParams**](SearchParams.md) |   | [optional]
**Page**| **long** | page number of the results you are processing  | [optional]
**TotalPages**| **long** | number of pages of results  | [optional]
**TotalHits**| **long** | number of total search results  | [optional]
**Hits**| **List<string>** | search result records contained in the specified page  | [optional]
**Aggregations**| [**Dictionary<string, SearchAggrMap>**](SearchAggrMap.md) | array of aggregation obtained by search result  | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

