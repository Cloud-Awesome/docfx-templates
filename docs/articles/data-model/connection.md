# Connection

Relationship between two entities. 

| Setting | Value | 
|---|---|
| Collection Name | Connections | 
| Logical Name | connection | 
| Primary attribute name | connectionid | 
| Object Type Code | 3234 | 
| Is custom table | No | 



---


## Attributes

| Display Name | Logical Name | Datatype | Description | 
|---|---|---|---|
| Modified By (Delegate) | modifiedonbehalfby | Lookup | Shows who last updated the record on behalf of another user. | 
| Type (From) | record1objecttypecode | Picklist | Shows the record type of the source record. | 
| Type (To) | record2objecttypecode | Picklist | Shows the record type of the target record. | 
| Ending | effectiveend | DateTime | Enter the end date of the connection. | 
| Currency | transactioncurrencyid | Lookup | Choose the local currency for the record to make sure budgets are reported in the correct currency. | 
| Entity Image | entityimage | Virtual | The default image for the entity. | 
| Owning User | owninguser | Lookup | Unique identifier of the user who owns the connection. | 
| Name (To) | record2idname | String | Display name for the target record. | 
| Entity Image Id | entityimageid | Uniqueidentifier | For internal use only. | 
| Starting | effectivestart | DateTime | Enter the start date of the connection. | 
| Import Sequence Number | importsequencenumber | Integer | Unique identifier of the data import or data migration that created this record. | 
| Created By (Delegate) | createdonbehalfby | Lookup | Shows who created the record on behalf of another user. | 
| Connection Name | name | String | Name of the connection. | 
| Name (From) | record1idname | String | Display name for the source record. | 
| Status Reason | statuscode | Status | Reason for the status of the connection. | 
| Owning Business Unit | owningbusinessunit | Lookup | Shows the business unit that the record owner belongs to. | 
| Version Number | versionnumber | BigInt | Version number of the connection. | 
| Modified By | modifiedby | Lookup | Shows who last updated the record. | 
| Created By | createdby | Lookup | Shows who created the record. | 
| Owning Team | owningteam | Lookup | Unique identifier of the team who owns the connection. | 
| Owner | ownerid | Owner | Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. | 
| Role (To) | record2roleid | Lookup | Choose the secondary party's role or relationship with the primary party. | 
| Modified On | modifiedon | DateTime | Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. | 
| Exchange Rate | exchangerate | Decimal | Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. | 
| Connected To | record2id | Lookup | Unique identifier of the target record. | 
| Status | statecode | State | Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated. | 
| Is Master | ismaster | Boolean | Indicates that this is the master record. | 
| Created On | createdon | DateTime | Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. | 
| Role (From) | record1roleid | Lookup | Choose the primary party's role or relationship with the second party. | 
| Description | description | Memo | Type additional information to describe the connection, such as the length or quality of the relationship. | 
| Connected From | record1id | Lookup | Unique identifier of the source record. | 
| Connection | connectionid | Uniqueidentifier | Unique identifier of the connection. | 
| Reciprocal Connection | relatedconnectionid | Lookup | Unique identifier for the reciprocal connection record. | 
| Record Created On | overriddencreatedon | DateTime | Date and time that the record was migrated. | 


 

## Relationships

### One to many relationships

| Related entity | Foreign key | Schema name | 
|---|---|---|
| asyncoperation | regardingobjectid | Connection_AsyncOperations | 
| connection | relatedconnectionid | connection_related_connection | 
| userentityinstancedata | objectid | userentityinstancedata_connection | 
| principalobjectattributeaccess | objectid | connection_principalobjectattributeaccess | 
| syncerror | regardingobjectid | Connection_SyncErrors | 
| processsession | regardingobjectid | Connection_ProcessSessions | 


 

### Many to relationships

| Primary entity | Foreign key | Schema name | 
|---|---|---|
| asyncoperation | regardingobjectid | Connection_AsyncOperations | 
| connection | relatedconnectionid | connection_related_connection | 
| userentityinstancedata | objectid | userentityinstancedata_connection | 
| principalobjectattributeaccess | objectid | connection_principalobjectattributeaccess | 
| syncerror | regardingobjectid | Connection_SyncErrors | 
| processsession | regardingobjectid | Connection_ProcessSessions | 


 

