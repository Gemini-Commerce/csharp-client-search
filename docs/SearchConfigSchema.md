# # SearchConfigSchema
contains index configurations fields

## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index**| **string** | index name, to create or where update configuration  |
**DocumentKeyName**| **string** | field which value will be used as document id [#DOCGENBUG REQUIRED FIELD]  | [optional]
**Attributes**| [**List<SearchConfigSchemaAttribute>**](SearchConfigSchemaAttribute.md) | fields that can be stored into index and later retrieved  |
**Searchables**| [**List<SearchConfigSchemaSearchable>**](SearchConfigSchemaSearchable.md) | fields that can be used for fulltext searches  | [optional]
**Facets**| [**List<SearchConfigSchemaFacet>**](SearchConfigSchemaFacet.md) | fields that can be used for aggregations  | [optional]
**Filters**| [**List<SearchConfigSchemaFilter>**](SearchConfigSchemaFilter.md) | fields that can be used for filtering  | [optional]
**Sortables**| [**List<SearchConfigSchemaSortable>**](SearchConfigSchemaSortable.md) | fields that can be used for sorting  | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

