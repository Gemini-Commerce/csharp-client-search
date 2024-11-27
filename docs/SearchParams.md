# # SearchParams
contains params needed to perform search

## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Offset**| **long** | number of the record where to start to take result for pagination  | [optional]
**Limit**| **long** | number of search result for page  | [optional]
**Term**| **string** | term to search  | [optional]
**Searchables**| [**List<SearchParamSearchable>**](SearchParamSearchable.md) | list of attributes where to search the indicated term, if not indicated it uses all in those present in index configuration  | [optional]
**Filters**| [**List<SearchParamFilter>**](SearchParamFilter.md) | list of attribute and relative value which you want to filter search results  | [optional]
**Attributes**| [**List<SearchParamAttribute>**](SearchParamAttribute.md) | attributes that you want to be present in search results  | [optional]
**Facets**| [**List<SearchParamFacet>**](SearchParamFacet.md) | list of attributes you want to create aggregation to make filter suggestion  | [optional]
**Sorts**| [**List<SearchParamSort>**](SearchParamSort.md) | params to sort search results  | [optional]
**MinScore**| **float** |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

