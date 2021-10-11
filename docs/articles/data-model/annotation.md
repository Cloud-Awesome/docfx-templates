# Note

Note that is attached to one or more objects, including other notes. 

| Setting | Value | 
|---|---|
| Collection Name | Notes | 
| Logical Name | annotation | 
| Primary attribute name | annotationid | 
| Object Type Code | 5 | 
| Is custom table | No | 



---


## Attributes

| Display Name | Logical Name | Datatype | Description | 
|---|---|---|---|
| Owning User | owninguser | Lookup | Unique identifier of the user who owns the note. | 
| Owning Team | owningteam | Lookup | Unique identifier of the team who owns the note. | 
| Regarding Object Type | objectidtypecode | EntityName |  | 
| Regarding | objectid | Lookup | Unique identifier of the object with which the note is associated. | 
| Prefix | prefix | String | Prefix of the file pointer in blob storage. | 
| File Pointer | filepointer | String | File pointer of the attachment. | 
| Created By (Delegate) | createdonbehalfby | Lookup | Unique identifier of the delegate user who created the annotation. | 
| Owning Business Unit | owningbusinessunit | Lookup | Unique identifier of the business unit that owns the note. | 
| File Name | filename | String | File name of the note. | 
| Import Sequence Number | importsequencenumber | Integer | Unique identifier of the data import or data migration that created this record. | 
| Title | subject | String | Subject associated with the note. | 
| Regarding | dummyregarding | String | Dummy attribute associated with the note regarding | 
| File Size (Bytes) | filesize | Integer | File size of the note. | 
| Version Number | versionnumber | BigInt | Version number of the note. | 
| Modified By | modifiedby | Lookup | Unique identifier of the user who last modified the note. | 
| Mime Type | mimetype | String | MIME type of the note's attachment. | 
| Created By | createdby | Lookup | Unique identifier of the user who created the note. | 
| Step Id | stepid | String | workflow step id associated with the note. | 
| Storage Pointer | storagepointer | String | Storage pointer. | 
| Description | notetext | Memo | Text of the note. | 
| File Name | dummyfilename | String | Dummy attribute associated with the note attachment | 
| Modified On | modifiedon | DateTime | Date and time when the note was last modified. | 
| Language ID | langid | String | Language identifier for the note. | 
| Owner | ownerid | Owner | Unique identifier of the user or team who owns the note. | 
| Created On | createdon | DateTime | Date and time when the note was created. | 
| Document | documentbody | String | Contents of the note's attachment. | 
| Is Document | isdocument | Boolean | Specifies whether the note is an attachment. | 
| Modified By (Delegate) | modifiedonbehalfby | Lookup | Unique identifier of the delegate user who last modified the annotation. | 
| Object Type  | objecttypecode | EntityName | Type of entity with which the note is associated. | 
| Record Created On | overriddencreatedon | DateTime | Date and time that the record was migrated. | 
| Note | annotationid | Uniqueidentifier | Unique identifier of the note. | 


 

## Relationships

### One to many relationships

| Related entity | Foreign key | Schema name | 
|---|---|---|
| syncerror | regardingobjectid | Annotation_SyncErrors | 
| asyncoperation | regardingobjectid | Annotation_AsyncOperations | 
| userentityinstancedata | objectid | userentityinstancedata_annotation | 
| bulkdeletefailure | regardingobjectid | Annotation_BulkDeleteFailures | 
| processsession | regardingobjectid | Annotation_ProcessSessions | 


 

### Many to relationships

| Primary entity | Foreign key | Schema name | 
|---|---|---|
| syncerror | regardingobjectid | Annotation_SyncErrors | 
| asyncoperation | regardingobjectid | Annotation_AsyncOperations | 
| userentityinstancedata | objectid | userentityinstancedata_annotation | 
| bulkdeletefailure | regardingobjectid | Annotation_BulkDeleteFailures | 
| processsession | regardingobjectid | Annotation_ProcessSessions | 


 

